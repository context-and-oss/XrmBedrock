#nullable enable
using System.Collections.Concurrent;
using System.Reflection;
using Microsoft.Xrm.Sdk;

namespace SharedContext.Dao;

public static class AliasedValueExtensions
{
    private static readonly ConcurrentDictionary<Type, string?> PrimaryIdAttributes = new ConcurrentDictionary<Type, string?>();

    /// <summary>
    /// Builds a typed entity from the AliasedValue attributes of one link entity alias.
    /// For a link entity with alias "contact" the attribute "contact.fullname" becomes "fullname" on the returned entity.
    /// Formatted values are copied the same way. Id is set when the primary key of <typeparamref name="T"/> is among the aliased values.
    /// </summary>
    /// <typeparam name="T">Entity type of the link entity</typeparam>
    /// <param name="source">Entity returned from a query with link entities</param>
    /// <param name="alias">Alias of the link entity</param>
    /// <returns>The related entity, or null when the source has no aliased values for the alias</returns>
    public static T? RelatedEntity<T>(this Entity source, string alias)
        where T : Entity
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        if (string.IsNullOrEmpty(alias))
            throw new ArgumentException("The alias cannot be empty.", nameof(alias));

        var prefix = alias + ".";
        var related = Activator.CreateInstance<T>();
        var primaryIdAttribute = PrimaryIdAttributes.GetOrAdd(typeof(T), FindPrimaryIdAttribute);
        var found = false;

        foreach (var attribute in source.Attributes)
        {
            if (!attribute.Key.StartsWith(prefix, StringComparison.Ordinal) || attribute.Value is not AliasedValue aliasedValue)
                continue;

            // AliasedValue.EntityLogicalName is not checked against T: XrmMockup puts the alias there instead of the entity name
            related[aliasedValue.AttributeLogicalName] = aliasedValue.Value;
            if (aliasedValue.Value is Guid id && string.Equals(aliasedValue.AttributeLogicalName, primaryIdAttribute, StringComparison.Ordinal))
                related.Id = id;

            found = true;
        }

        if (!found)
            return null;

        foreach (var formattedValue in source.FormattedValues.Where(x => x.Key.StartsWith(prefix, StringComparison.Ordinal)))
        {
            related.FormattedValues[formattedValue.Key.Substring(prefix.Length)] = formattedValue.Value;
        }

        return related;
    }

    private static string? FindPrimaryIdAttribute(Type entityType)
    {
        // Generated classes override Id with [AttributeLogicalName("<primary key>")]
        for (var current = entityType; current != null && current != typeof(Entity); current = current.BaseType)
        {
            var idProperty = current.GetProperty(nameof(Entity.Id), BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var attribute = idProperty?.GetCustomAttributes(typeof(AttributeLogicalNameAttribute), false).OfType<AttributeLogicalNameAttribute>().FirstOrDefault();
            if (attribute != null)
                return attribute.LogicalName;
        }

        return null;
    }
}
