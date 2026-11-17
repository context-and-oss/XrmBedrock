using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;

namespace SharedContext.Dao;

public static class DataverseStaticExtensions
{
    private static readonly ConcurrentDictionary<Type, string> EntityLogicalNames = new();

    /// <summary>
    /// Extracts the attribute logical name of a lambda expression pointing to an attribute of entity T eg. for x => x.Name, "name" will be extracted.
    /// The name is read from [AttributeLogicalName] on the property, so x => x.Id gives the primary key column (eg. "accountid").
    /// Falls back to the lowercased member name when the member has no [AttributeLogicalName].
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <returns></returns>
    public static string StringOf<T>(this Expression<Func<T, object>> expr)
    {
        return StaticReflection.GetAttributeLogicalName<T>(expr);
    }

    public static string StringOf<T>(this Expression<Func<T, EntityReference>> expr)
    {
        return StaticReflection.GetAttributeLogicalName<T>(expr);
    }

    /// <summary>
    /// Converts an Expression{Func{T, TSpecific}} to Expression{Func{T, object}} for use with generic Retrieve methods
    /// </summary>
    /// <typeparam name="T">The entity type</typeparam>
    /// <typeparam name="TSpecific">The specific return type of the original expression</typeparam>
    /// <param name="expr">The expression to convert</param>
    /// <returns>An expression that returns object instead of the specific type</returns>
    public static Expression<Func<T, object>> ToObjectExpression<T, TSpecific>(this Expression<Func<T, TSpecific>> expr)
    {
        var parameter = expr.Parameters[0];
        var convertedBody = Expression.Convert(expr.Body, typeof(object));
        return Expression.Lambda<Func<T, object>>(convertedBody, parameter);
    }

    /// <summary>
    /// Returns the logical name of entity <typeparamref name="T"/>. The value is resolved once per type and cached.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static string LogicalName<T>()
        where T : Entity => EntityLogicalNames.GetOrAdd(typeof(T), _ => Activator.CreateInstance<T>().LogicalName);

    public static EntityReference ToEntityReference<T>(this Guid entityId)
        where T : Entity => new EntityReference(LogicalName<T>(), entityId);

    // This one could probably be in XrmExtensions instead
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "We will allow this here")]
    public static List<ExecuteMultipleResponseItem> PerformAsBulk<T>(this IOrganizationService service, IEnumerable<T> requests, bool continueOnError = true, int chunkSize = 1000)
        where T : OrganizationRequest
    {
        var arr = requests.ToArray();
        var splitReqs = from i in Enumerable.Range(0, arr.Length)
                        group arr[i] by i / chunkSize;

        var resps = new List<ExecuteMultipleResponseItem>();
        foreach (var rs in splitReqs)
        {
            var req = new ExecuteMultipleRequest
            {
                Requests = new OrganizationRequestCollection(),
            };
            req.Requests.AddRange(rs);
            req.Settings = new ExecuteMultipleSettings
            {
                ContinueOnError = continueOnError,
                ReturnResponses = true,
            };
            var resp = service.Execute(req) as ExecuteMultipleResponse ?? throw new InvalidOperationException("Unable to obtain ExecuteMultipleResponse");
            resps.AddRange(resp.Responses);
        }

        return resps;
    }

    /// <summary>
    /// Pseudo method to take the non-nullable value of a entityId (which should never be null).
    /// This is to avoid null checks in the code, where stylecop ignores it.
    /// </summary>
    /// <param name="nullableGuid">Input</param>
    /// <returns>Output</returns>
    /// <exception cref="ArgumentException"></exception>
    public static Guid GetRequiredValue(this Guid? nullableGuid)
        => nullableGuid ?? throw new ArgumentException("Guid is null", nameof(nullableGuid));

    /// <summary>
    /// Takes a substring of the string input if it is longer than allowed by the specified attribute.
    /// </summary>
    /// <typeparam name="T">Entity of the attribute</typeparam>
    /// <param name="stringValue">Value to truncate</param>
    /// <param name="attributeExpression">Must specify an attribute of type 'string' (text)</param>
    /// <returns></returns>
    public static string TruncateIfOutOfRange<T>(string stringValue, Expression<Func<T, object>> attributeExpression)
        where T : Entity
    {
        var maxLength = GetStringAttributeMaxLenth(attributeExpression);
        return stringValue.Length > maxLength ? stringValue.Substring(0, maxLength - 1) : stringValue;
    }

    /// <summary>
    /// Return the allowed lenght of the string attribute.
    /// </summary>
    /// <typeparam name="T">Entity of the attribute</typeparam>
    /// <param name="attributeExpression">Must specify an attribute of type 'string' (text)</param>
    /// <returns>Allowd max length</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "MA0015:Specify the parameter name in ArgumentException", Justification = "We will allow this here")]
    public static int GetStringAttributeMaxLenth<T>(Expression<Func<T, object>> attributeExpression)
        where T : Entity
    {
        // Get the attribute/porperty name
        var propertyName = StaticReflection.GetMemberName(attributeExpression);

        Type type = typeof(T);
        var property = type.GetProperty(propertyName);

        // Check if the property exists
        if (property == null)
            throw new ArgumentException($"Property '{propertyName}' not found in type '{type.FullName}'");

        // Get the MaxLength attribute and Check if the MaxLength attribute is found
        MaxLengthAttribute? maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                                                         .Cast<MaxLengthAttribute>()
                                                         .FirstOrDefault()
                                                         ?? throw new InvalidOperationException($"MaxLength attribute not found on property '{propertyName}'");

        // Return the length value from the MaxLength attribute
        return maxLengthAttribute.Length;
    }

    /// <summary>
    /// For use in comparing two EntityReference objects, as the default comparison is by reference and not by value.
    /// Use in .Distinct() or .Contains() for example.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "We will allow this here")]
    public sealed class EntityReferenceComparer : IEqualityComparer<EntityReference>
    {
        public bool Equals(EntityReference? x, EntityReference? y)
        {
            if (x is null && y is null)
                return true;
            if (x is null || y is null)
                return false;
            return x.LogicalName == y.LogicalName && x.Id == y.Id;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA1307:Use StringComparer.GetHashCode instead of string.GetHashCode", Justification = "We will allow this here")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "MA0001:Use StringComparer.GetHashCode instead of string.GetHashCode", Justification = "We will allow this here")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "MA0021:Use StringComparer.GetHashCode instead of string.GetHashCode", Justification = "We will allow this here")]
        public int GetHashCode(EntityReference obj)
        {
            if (obj is null)
                return 0;

            unchecked
            {
                int hash = 17;
                hash = (hash * 31) + (obj.LogicalName?.GetHashCode() ?? 0);
                hash = (hash * 31) + obj.Id.GetHashCode();
                return hash;
            }
        }
    }

    /// <summary>
    /// http://joelabrahamsson.com/getting-property-and-method-names-using-static-reflection-in-c/
    /// </summary>
    private static class StaticReflection
    {
        private static readonly ConcurrentDictionary<(Type EntityType, MemberInfo Member), string> AttributeLogicalNames = new();

        public static string GetAttributeLogicalName<T>(LambdaExpression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression), "The expression cannot be null.");

            var member = GetMember(expression.Body);
            return AttributeLogicalNames.GetOrAdd((typeof(T), member), key => ResolveAttributeLogicalName(key.EntityType, key.Member));
        }

        public static string GetMemberName<T>(Expression<Func<T, object>> expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression), "The expression cannot be null.");
            return GetMemberName(expression.Body);
        }

        private static string GetMemberName(Expression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression), "The expression cannot be null.");

            if (expression is MemberExpression)
            {
                // Reference type property or field
                var memberExpression = (MemberExpression)expression;
                return memberExpression.Member.Name;
            }

            if (expression is MethodCallExpression)
            {
                // Reference type method
                var methodCallExpression = (MethodCallExpression)expression;
                return methodCallExpression.Method.Name;
            }

            if (expression is UnaryExpression)
            {
                // Property, field of method returning value type
                var unaryExpression = (UnaryExpression)expression;
                return GetMemberName(unaryExpression);
            }

            throw new ArgumentException("Invalid expression", nameof(expression));
        }

        private static string GetMemberName(UnaryExpression unaryExpression)
        {
            if (unaryExpression.Operand is MethodCallExpression)
            {
                var methodExpression = (MethodCallExpression)unaryExpression.Operand;
                return methodExpression.Method.Name;
            }

            return ((MemberExpression)unaryExpression.Operand).Member.Name;
        }

        private static MemberInfo GetMember(Expression expression)
        {
            switch (expression)
            {
                case MemberExpression memberExpression:
                    return memberExpression.Member;
                case MethodCallExpression methodCallExpression:
                    return methodCallExpression.Method;
                case UnaryExpression unaryExpression:
                    return GetMember(unaryExpression.Operand);
                default:
                    throw new ArgumentException("Invalid expression", nameof(expression));
            }
        }

        private static string ResolveAttributeLogicalName(Type entityType, MemberInfo member)
        {
            // Expression trees bind overridden properties to their base declaration, eg. x => x.Id gives Entity.Id.
            // The [AttributeLogicalName] is on the override in the generated class, so look the property up on the entity type.
            var property = member is PropertyInfo ? FindMostDerivedProperty(entityType, member.Name) ?? member : member;
            var attribute = property.GetCustomAttributes(typeof(AttributeLogicalNameAttribute), false)
                .OfType<AttributeLogicalNameAttribute>()
                .FirstOrDefault();
            return attribute?.LogicalName ?? member.Name.ToLower(CultureInfo.InvariantCulture);
        }

        private static PropertyInfo FindMostDerivedProperty(Type type, string name)
        {
            for (var current = type; current != null; current = current.BaseType)
            {
                var property = current.GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (property != null)
                    return property;
            }

            return null;
        }
    }
}
