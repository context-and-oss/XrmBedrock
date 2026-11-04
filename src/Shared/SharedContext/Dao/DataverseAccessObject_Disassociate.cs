using System.Runtime.CompilerServices;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;

namespace SharedContext.Dao;

public partial class DataverseAccessObject : IDataverseAccessObject
{
    /// <summary>
    /// Generic method that Disassociates two entities in XRM via the N:N relationship <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="target"></param>
    /// <param name="relatedEntity"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public OrganizationResponse DisassociateEntities<T>(EntityReference target, EntityReference relatedEntity, [CallerMemberName] string callerMethodName = "") where T : Entity
    {
        return DisassociateEntities(typeof(T).Name, target, relatedEntity, callerMethodName);
    }

    /// <summary>
    /// Generic method that Disassociates two entities in XRM via the N:N relationship relationshipName (this is an overload of DisassociateEntities which is only introduced due to tooling issues regarding the casing of relationshipnames)
    /// </summary>
    /// <param name="relationshipName"></param>
    /// <param name="target"></param>
    /// <param name="relatedEntity"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public OrganizationResponse DisassociateEntities(string relationshipName, EntityReference target, EntityReference relatedEntity, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccess.WrapFunction(
            logger,
            $"Disassociate({target.Id},{relatedEntity})",
            relationshipName,
            () => { return DisassociateEntitiesCore(relationshipName, target, relatedEntity, callerMethodName); },
            callerMethodName
            );
    }

    private OrganizationResponse DisassociateEntitiesCore(string relationshipName, EntityReference target, EntityReference relatedEntity, [CallerMemberName] string callerMethodName = "")
    {
        var request = new DisassociateRequest
        {
            Target = target,
            RelatedEntities = new EntityReferenceCollection { relatedEntity },
            Relationship = new Relationship(relationshipName)
        };
        return Execute(request, callerMethodName);
    }
}