using System.Runtime.CompilerServices;
using Microsoft.Xrm.Sdk;

namespace SharedContext.Dao;

public partial class DataverseAccessObject : IDataverseAccessObject
{
    /// <summary>
    /// Generic method that creates an entity of type <typeparamref name="T"/> in XRM
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Guid Create<T>(T entity, [CallerMemberName] string callerMethodName = "")
        where T : Entity
    {
        return DataverseWrapAccess.WrapFunction(logger, "Create", entity.LogicalName, () => orgService.Create(entity), callerMethodName, $" with data '{DataverseWrapAccess.GetAttributesFormatted(entity)}'");
    }
}
