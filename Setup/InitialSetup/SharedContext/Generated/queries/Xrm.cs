using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
public class Xrm : OrganizationServiceContext
{
    public Xrm(IOrganizationService service)
        : base(service)
    {
    }

    public IQueryable<Account> AccountSet
    {
        get { return CreateQuery<Account>(); }
    }

    public IQueryable<ActivityParty> ActivityPartySet
    {
        get { return CreateQuery<ActivityParty>(); }
    }

    public IQueryable<Annotation> AnnotationSet
    {
        get { return CreateQuery<Annotation>(); }
    }

    public IQueryable<appnotification> appnotificationSet
    {
        get { return CreateQuery<appnotification>(); }
    }

    public IQueryable<Contact> ContactSet
    {
        get { return CreateQuery<Contact>(); }
    }

    public IQueryable<DuplicateRule> DuplicateRuleSet
    {
        get { return CreateQuery<DuplicateRule>(); }
    }

    public IQueryable<EnvironmentVariableDefinition> EnvironmentVariableDefinitionSet
    {
        get { return CreateQuery<EnvironmentVariableDefinition>(); }
    }

    public IQueryable<EnvironmentVariableValue> EnvironmentVariableValueSet
    {
        get { return CreateQuery<EnvironmentVariableValue>(); }
    }

    public IQueryable<Queue> QueueSet
    {
        get { return CreateQuery<Queue>(); }
    }

    public IQueryable<SavedQuery> SavedQuerySet
    {
        get { return CreateQuery<SavedQuery>(); }
    }

    public IQueryable<SystemUser> SystemUserSet
    {
        get { return CreateQuery<SystemUser>(); }
    }

    public IQueryable<Task> TaskSet
    {
        get { return CreateQuery<Task>(); }
    }

    public IQueryable<Template> TemplateSet
    {
        get { return CreateQuery<Template>(); }
    }
}
