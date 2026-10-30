using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using XrmBedrock.SharedContext;
using Task = System.Threading.Tasks.Task;

namespace DataverseService.Foundation.Dao;

public interface IDataverseAccessObjectAsync : IAdminDataverseAccessObjectService
{
    Task<OrganizationResponse> AssociateEntitiesAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> AssociateEntitiesAsync(string relationshipName, EntityReference target, IEnumerable<EntityReference> relatedEntities, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> AssociateEntitiesAsync<T>(EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "") where T : Entity;
    Task<OrganizationResponse> AssociateEntitiesUnawaitedAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> AssociateEntitiesUnawaitedAsync(string relationshipName, EntityReference target, IEnumerable<EntityReference> relatedEntities, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> AssociateEntitiesUnawaitedAsync<T>(EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "") where T : Entity;
    Task<Guid> CreateAsync<T0>(T0 entity, [CallerMemberName] string methodName = "") where T0 : Entity;
    Task<Guid> CreateUnawaitedAsync<T0>(T0 entity, [CallerMemberName] string methodName = "") where T0 : Entity;
    Task DeleteAsync<T>(Guid entityGuid, [CallerMemberName] string methodName = "") where T : Entity;
    Task DeleteUnawaitedAsync<T0>(Guid entityGuid, [CallerMemberName] string methodName = "") where T0 : Entity;
    Task<OrganizationResponse> DisassociateEntitiesAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> DisassociateEntitiesAsync<T>(EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "") where T : Entity;
    Task<OrganizationResponse> DisassociateEntitiesUnawaitedAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> DisassociateEntitiesUnawaitedAsync<T>(EntityReference target, EntityReference relatedEntity, [CallerMemberName] string methodName = "") where T : Entity;
    Task<OrganizationResponse> ExecuteAsync(OrganizationRequest request, [CallerMemberName] string methodName = "");
    Task<OrganizationResponse> ExecuteUnawaitedAsync(OrganizationRequest request, [CallerMemberName] string methodName = "");
    Task<T> RetrieveAsync<T>(Guid guidOfElement, params Expression<Func<T, object?>>[] columnExpressions) where T : Entity;
    Task<T> RetrieveCachableAsync<T>(string cacheKey, Guid guidOfElement, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<T>> RetrieveListAsync<T>(QueryExpression query, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, QueryExpression query, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, string fieldName, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<Entity>> RetrieveMultipleAsync(QueryExpression query, [CallerMemberName] string callerMethodName = "");
    Task<List<Entity>> RetrieveMultipleCachableAsync(string cacheKey, QueryExpression query, [CallerMemberName] string callerMethodName = "");
    void SetCancellationToken(CancellationToken cancellationToken);
    Task UpdateAsync<T0>(T0 entity, [CallerMemberName] string methodName = "") where T0 : Entity;
    Task UpdateUnawaitedAsync<T0>(T0 entity, [CallerMemberName] string methodName = "") where T0 : Entity;
}
