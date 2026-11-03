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
    Task<OrganizationResponse> AssociateEntitiesAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> AssociateEntitiesAsync(string relationshipName, EntityReference target, IEnumerable<EntityReference> relatedEntities, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> AssociateEntitiesAsync<T>(EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<OrganizationResponse> AssociateEntitiesUnawaitedAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> AssociateEntitiesUnawaitedAsync(string relationshipName, EntityReference target, IEnumerable<EntityReference> relatedEntities, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> AssociateEntitiesUnawaitedAsync<T>(EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<Guid> CreateAsync<T0>(T0 entity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T0 : Entity;
    Task<Guid> CreateUnawaitedAsync<T0>(T0 entity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T0 : Entity;
    Task DeleteAsync<T>(Guid entityGuid, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task DeleteUnawaitedAsync<T0>(Guid entityGuid, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T0 : Entity;
    Task<OrganizationResponse> DisassociateEntitiesAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> DisassociateEntitiesAsync<T>(EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<OrganizationResponse> DisassociateEntitiesUnawaitedAsync(string relationshipName, EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> DisassociateEntitiesUnawaitedAsync<T>(EntityReference target, EntityReference relatedEntity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<OrganizationResponse> ExecuteAsync(OrganizationRequest request, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<OrganizationResponse> ExecuteUnawaitedAsync(OrganizationRequest request, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<T> RetrieveAsync<T>(Guid guidOfElement, params Expression<Func<T, object?>>[] columnExpressions) where T : Entity;
    Task<T> RetrieveWithCtAsync<T>(Guid guidOfElement, CancellationToken ct, params Expression<Func<T, object?>>[] columnExpressions) where T : Entity;
    Task<T> RetrieveCachableAsync<T>(string cacheKey, Guid guidOfElement, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<T> RetrieveCachableWithCtAsync<T>(string cacheKey, Guid guidOfElement, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<Entity>> RetrieveListAsync(QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<List<T>> RetrieveListAsync<T>(QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<List<T>> RetrieveListAsync<T>(Func<Xrm, IQueryable<T>> delegateQueryFunction, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<List<T>> RetrieveListAsync<T>(Func<Xrm, IQueryable<T>> delegateQueryFunction, Func<Entity, T> mapper, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, Func<Xrm, IQueryable<T>> delegateQueryFunction, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, Func<Xrm, IQueryable<T>> delegateQueryFunction, Func<Entity, T> mapper, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<List<Entity>> RetrieveListCachableAsync(string cacheKey, QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "");
    Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T : Entity;
    Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, string fieldName, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<T>> RetrieveMultipleByIdsWithCtAsync<T>(IEnumerable<Guid> guids, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    Task<List<T>> RetrieveMultipleByIdsWithCtAsync<T>(IEnumerable<Guid> guids, string fieldName, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions) where T : Entity;
    void SetCancellationToken(CancellationToken cancellationToken);
    Task UpdateAsync<T0>(T0 entity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T0 : Entity;
    Task UpdateUnawaitedAsync<T0>(T0 entity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "") where T0 : Entity;
}