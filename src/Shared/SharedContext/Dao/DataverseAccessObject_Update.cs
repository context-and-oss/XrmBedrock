using System.Runtime.CompilerServices;
using Microsoft.Xrm.Sdk;

namespace SharedContext.Dao;

public partial class DataverseAccessObject : IDataverseAccessObject
{
    /// <summary>
    /// Generic method that updates an entity of type <typeparamref name="T"/> in XRM
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <param name="callerMethodName"></param>
    public void Update<T>(T entity, [CallerMemberName] string callerMethodName = "") where T : Entity
    {
        DataverseWrapAccess.WrapAction(logger, $"Update({entity.Id})", entity.LogicalName, () => orgService.Update(entity), callerMethodName, $" with data '{DataverseWrapAccess.GetAttributesFormatted(entity)}'");
    }
}