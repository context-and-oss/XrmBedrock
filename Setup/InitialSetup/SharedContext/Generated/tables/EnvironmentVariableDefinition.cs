using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>Contains information about the settable variable: its type, default value, and etc.</para>
/// <para>Display Name: Environment Variable Definition</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("environmentvariabledefinition")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class EnvironmentVariableDefinition : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "environmentvariabledefinition";
    public const int EntityTypeCode = 380;

    public EnvironmentVariableDefinition() : base(EntityLogicalName) { }
    public EnvironmentVariableDefinition(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("schemaname");

    [AttributeLogicalName("environmentvariabledefinitionid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("environmentvariabledefinitionid", value);
        }
    }

    /// <summary>
    /// <para>Display Name: API Id</para>
    /// </summary>
    [AttributeLogicalName("apiid")]
    [DisplayName("API Id")]
    [MaxLength(150)]
    public string? ApiId
    {
        get => GetAttributeValue<string?>("apiid");
        set => SetAttributeValue("apiid", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Component State</para>
    /// </summary>
    [AttributeLogicalName("componentstate")]
    [DisplayName("Component State")]
    public componentstate? ComponentState
    {
        get => this.GetOptionSetValue<componentstate>("componentstate");
        set => this.SetOptionSetValue("componentstate", value);
    }

    /// <summary>
    /// <para>Unique identifier for Connection Reference associated with Environment Variable Definition.</para>
    /// <para>Display Name: Connection Reference</para>
    /// </summary>
    [AttributeLogicalName("connectionreferenceid")]
    [DisplayName("Connection Reference")]
    public EntityReference? ConnectionReferenceId
    {
        get => GetAttributeValue<EntityReference?>("connectionreferenceid");
        set => SetAttributeValue("connectionreferenceid", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who created the record.</para>
    /// <para>Display Name: Created By</para>
    /// </summary>
    [AttributeLogicalName("createdby")]
    [DisplayName("Created By")]
    public EntityReference? CreatedBy
    {
        get => GetAttributeValue<EntityReference?>("createdby");
        set => SetAttributeValue("createdby", value);
    }

    /// <summary>
    /// <para>Date and time when the record was created.</para>
    /// <para>Display Name: Created On</para>
    /// </summary>
    [AttributeLogicalName("createdon")]
    [DisplayName("Created On")]
    public DateTime? CreatedOn
    {
        get => GetAttributeValue<DateTime?>("createdon");
        set => SetAttributeValue("createdon", value);
    }

    /// <summary>
    /// <para>Unique identifier of the delegate user who created the record.</para>
    /// <para>Display Name: Created By (Delegate)</para>
    /// </summary>
    [AttributeLogicalName("createdonbehalfby")]
    [DisplayName("Created By (Delegate)")]
    public EntityReference? CreatedOnBehalfBy
    {
        get => GetAttributeValue<EntityReference?>("createdonbehalfby");
        set => SetAttributeValue("createdonbehalfby", value);
    }

    /// <summary>
    /// <para>Default variable value to be used if no associated EnvironmentVariableValue entities exist.</para>
    /// <para>Display Name: Default Value</para>
    /// </summary>
    [AttributeLogicalName("defaultvalue")]
    [DisplayName("Default Value")]
    [MaxLength(2000)]
    public string? DefaultValue
    {
        get => GetAttributeValue<string?>("defaultvalue");
        set => SetAttributeValue("defaultvalue", value);
    }

    /// <summary>
    /// <para>Description of the variable definition.</para>
    /// <para>Display Name: Description</para>
    /// </summary>
    [AttributeLogicalName("description")]
    [DisplayName("Description")]
    [MaxLength(2000)]
    public string? Description
    {
        get => GetAttributeValue<string?>("description");
        set => SetAttributeValue("description", value);
    }

    /// <summary>
    /// <para>Display Name of the variable definition.</para>
    /// <para>Display Name: Display Name</para>
    /// </summary>
    [AttributeLogicalName("displayname")]
    [DisplayName("Display Name")]
    [MaxLength(100)]
    public string? DisplayName
    {
        get => GetAttributeValue<string?>("displayname");
        set => SetAttributeValue("displayname", value);
    }

    /// <summary>
    /// <para>Display Name: Environment Variable Definition</para>
    /// </summary>
    [AttributeLogicalName("environmentvariabledefinitionid")]
    [DisplayName("Environment Variable Definition")]
    public Guid? EnvironmentVariableDefinitionId
    {
        get => GetAttributeValue<Guid?>("environmentvariabledefinitionid");
        set => SetId("environmentvariabledefinitionid", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: environmentvariabledefinitionidunique</para>
    /// </summary>
    [AttributeLogicalName("environmentvariabledefinitionidunique")]
    [DisplayName("environmentvariabledefinitionidunique")]
    public Guid? EnvironmentVariableDefinitionIdUnique
    {
        get => GetAttributeValue<Guid?>("environmentvariabledefinitionidunique");
        set => SetAttributeValue("environmentvariabledefinitionidunique", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Hint</para>
    /// </summary>
    [AttributeLogicalName("hint")]
    [DisplayName("Hint")]
    [MaxLength(2000)]
    public string? Hint
    {
        get => GetAttributeValue<string?>("hint");
        set => SetAttributeValue("hint", value);
    }

    /// <summary>
    /// <para>Sequence number of the import that created this record.</para>
    /// <para>Display Name: Import Sequence Number</para>
    /// </summary>
    [AttributeLogicalName("importsequencenumber")]
    [DisplayName("Import Sequence Number")]
    [Range(-2147483648, 2147483647)]
    public int? ImportSequenceNumber
    {
        get => GetAttributeValue<int?>("importsequencenumber");
        set => SetAttributeValue("importsequencenumber", value);
    }

    /// <summary>
    /// <para>A JSON object describing the options for the input control that should be presented to the user for setting the current value of the Environment variable.</para>
    /// <para>Display Name: Input Control Config</para>
    /// </summary>
    [AttributeLogicalName("inputcontrolconfig")]
    [DisplayName("Input Control Config")]
    [MaxLength(10000)]
    public string? InputControlConfig
    {
        get => GetAttributeValue<string?>("inputcontrolconfig");
        set => SetAttributeValue("inputcontrolconfig", value);
    }

    /// <summary>
    /// <para>Version in which the form is introduced.</para>
    /// <para>Display Name: Introduced Version</para>
    /// </summary>
    [AttributeLogicalName("introducedversion")]
    [DisplayName("Introduced Version")]
    [MaxLength(48)]
    public string? IntroducedVersion
    {
        get => GetAttributeValue<string?>("introducedversion");
        set => SetAttributeValue("introducedversion", value);
    }

    /// <summary>
    /// <para>Tells whether the component can be customized.</para>
    /// <para>Display Name: Customizable</para>
    /// </summary>
    [AttributeLogicalName("iscustomizable")]
    [DisplayName("Customizable")]
    public BooleanManagedProperty IsCustomizable
    {
        get => GetAttributeValue<BooleanManagedProperty>("iscustomizable");
        set => SetAttributeValue("iscustomizable", value);
    }

    /// <summary>
    /// <para>Indicates whether the solution component is part of a managed solution.</para>
    /// <para>Display Name: Is Managed</para>
    /// </summary>
    [AttributeLogicalName("ismanaged")]
    [DisplayName("Is Managed")]
    public bool? IsManaged
    {
        get => GetAttributeValue<bool?>("ismanaged");
        set => SetAttributeValue("ismanaged", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Is Required</para>
    /// </summary>
    [AttributeLogicalName("isrequired")]
    [DisplayName("Is Required")]
    public bool? IsRequired
    {
        get => GetAttributeValue<bool?>("isrequired");
        set => SetAttributeValue("isrequired", value);
    }

    /// <summary>
    /// <para>Clicking on this url will take the user to a webpage which further explains the environment variable being populated.</para>
    /// <para>Display Name: Learn More Url</para>
    /// </summary>
    [AttributeLogicalName("learnmoreurl")]
    [DisplayName("Learn More Url")]
    [MaxLength(2000)]
    public string? LearnMoreUrl
    {
        get => GetAttributeValue<string?>("learnmoreurl");
        set => SetAttributeValue("learnmoreurl", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who modified the record.</para>
    /// <para>Display Name: Modified By</para>
    /// </summary>
    [AttributeLogicalName("modifiedby")]
    [DisplayName("Modified By")]
    public EntityReference? ModifiedBy
    {
        get => GetAttributeValue<EntityReference?>("modifiedby");
        set => SetAttributeValue("modifiedby", value);
    }

    /// <summary>
    /// <para>Date and time when the record was modified.</para>
    /// <para>Display Name: Modified On</para>
    /// </summary>
    [AttributeLogicalName("modifiedon")]
    [DisplayName("Modified On")]
    public DateTime? ModifiedOn
    {
        get => GetAttributeValue<DateTime?>("modifiedon");
        set => SetAttributeValue("modifiedon", value);
    }

    /// <summary>
    /// <para>Unique identifier of the delegate user who modified the record.</para>
    /// <para>Display Name: Modified By (Delegate)</para>
    /// </summary>
    [AttributeLogicalName("modifiedonbehalfby")]
    [DisplayName("Modified By (Delegate)")]
    public EntityReference? ModifiedOnBehalfBy
    {
        get => GetAttributeValue<EntityReference?>("modifiedonbehalfby");
        set => SetAttributeValue("modifiedonbehalfby", value);
    }

    /// <summary>
    /// <para>Date and time that the record was migrated.</para>
    /// <para>Display Name: Record Created On</para>
    /// </summary>
    [AttributeLogicalName("overriddencreatedon")]
    [DisplayName("Record Created On")]
    public DateTime? OverriddenCreatedOn
    {
        get => GetAttributeValue<DateTime?>("overriddencreatedon");
        set => SetAttributeValue("overriddencreatedon", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Record Overwrite Time</para>
    /// </summary>
    [AttributeLogicalName("overwritetime")]
    [DisplayName("Record Overwrite Time")]
    public DateTime? OverwriteTime
    {
        get => GetAttributeValue<DateTime?>("overwritetime");
        set => SetAttributeValue("overwritetime", value);
    }

    /// <summary>
    /// <para>Owner Id</para>
    /// <para>Display Name: Owner</para>
    /// </summary>
    [AttributeLogicalName("ownerid")]
    [DisplayName("Owner")]
    public EntityReference? OwnerId
    {
        get => GetAttributeValue<EntityReference?>("ownerid");
        set => SetAttributeValue("ownerid", value);
    }

    /// <summary>
    /// <para>Unique identifier for the business unit that owns the record</para>
    /// <para>Display Name: Owning Business Unit</para>
    /// </summary>
    [AttributeLogicalName("owningbusinessunit")]
    [DisplayName("Owning Business Unit")]
    public EntityReference? OwningBusinessUnit
    {
        get => GetAttributeValue<EntityReference?>("owningbusinessunit");
        set => SetAttributeValue("owningbusinessunit", value);
    }

    /// <summary>
    /// <para>Unique identifier for the team that owns the record.</para>
    /// <para>Display Name: Owning Team</para>
    /// </summary>
    [AttributeLogicalName("owningteam")]
    [DisplayName("Owning Team")]
    public EntityReference? OwningTeam
    {
        get => GetAttributeValue<EntityReference?>("owningteam");
        set => SetAttributeValue("owningteam", value);
    }

    /// <summary>
    /// <para>Unique identifier for the user that owns the record.</para>
    /// <para>Display Name: Owning User</para>
    /// </summary>
    [AttributeLogicalName("owninguser")]
    [DisplayName("Owning User")]
    public EntityReference? OwningUser
    {
        get => GetAttributeValue<EntityReference?>("owninguser");
        set => SetAttributeValue("owninguser", value);
    }

    /// <summary>
    /// <para>Display Name: Parameter Key</para>
    /// </summary>
    [AttributeLogicalName("parameterkey")]
    [DisplayName("Parameter Key")]
    [MaxLength(150)]
    public string? ParameterKey
    {
        get => GetAttributeValue<string?>("parameterkey");
        set => SetAttributeValue("parameterkey", value);
    }

    /// <summary>
    /// <para>Unique identifier for Environment Variable Definition associated with Environment Variable Definition.</para>
    /// <para>Display Name: Parent Definition</para>
    /// </summary>
    [AttributeLogicalName("parentdefinitionid")]
    [DisplayName("Parent Definition")]
    public EntityReference? ParentDefinitionId
    {
        get => GetAttributeValue<EntityReference?>("parentdefinitionid");
        set => SetAttributeValue("parentdefinitionid", value);
    }

    /// <summary>
    /// <para>Unique entity name.</para>
    /// <para>Display Name: Schema Name</para>
    /// </summary>
    [AttributeLogicalName("schemaname")]
    [DisplayName("Schema Name")]
    [MaxLength(100)]
    public string? SchemaName
    {
        get => GetAttributeValue<string?>("schemaname");
        set => SetAttributeValue("schemaname", value);
    }

    /// <summary>
    /// <para>Environment variable secret store.</para>
    /// <para>Display Name: SecretStore</para>
    /// </summary>
    [AttributeLogicalName("secretstore")]
    [DisplayName("SecretStore")]
    public environmentvariabledefinition_secretstore? SecretStore
    {
        get => this.GetOptionSetValue<environmentvariabledefinition_secretstore>("secretstore");
        set => this.SetOptionSetValue("secretstore", value);
    }

    /// <summary>
    /// <para>Unique identifier of the associated solution.</para>
    /// <para>Display Name: Solution</para>
    /// </summary>
    [AttributeLogicalName("solutionid")]
    [DisplayName("Solution")]
    public Guid? SolutionId
    {
        get => GetAttributeValue<Guid?>("solutionid");
        set => SetAttributeValue("solutionid", value);
    }

    /// <summary>
    /// <para>Status of the Environment Variable Definition</para>
    /// <para>Display Name: Status</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Status")]
    public environmentvariabledefinition_statecode? statecode
    {
        get => this.GetOptionSetValue<environmentvariabledefinition_statecode>("statecode");
        set => this.SetOptionSetValue("statecode", value);
    }

    /// <summary>
    /// <para>Reason for the status of the Environment Variable Definition</para>
    /// <para>Display Name: Status Reason</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Status Reason")]
    public environmentvariabledefinition_statuscode? statuscode
    {
        get => this.GetOptionSetValue<environmentvariabledefinition_statuscode>("statuscode");
        set => this.SetOptionSetValue("statuscode", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Solution</para>
    /// </summary>
    [AttributeLogicalName("supportingsolutionid")]
    [DisplayName("Solution")]
    public Guid? SupportingSolutionId
    {
        get => GetAttributeValue<Guid?>("supportingsolutionid");
        set => SetAttributeValue("supportingsolutionid", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Time Zone Rule Version Number</para>
    /// </summary>
    [AttributeLogicalName("timezoneruleversionnumber")]
    [DisplayName("Time Zone Rule Version Number")]
    [Range(-1, 2147483647)]
    public int? TimeZoneRuleVersionNumber
    {
        get => GetAttributeValue<int?>("timezoneruleversionnumber");
        set => SetAttributeValue("timezoneruleversionnumber", value);
    }

    /// <summary>
    /// <para>Environment variable value type.</para>
    /// <para>Display Name: Type</para>
    /// </summary>
    [AttributeLogicalName("type")]
    [DisplayName("Type")]
    public environmentvariabledefinition_type? Type
    {
        get => this.GetOptionSetValue<environmentvariabledefinition_type>("type");
        set => this.SetOptionSetValue("type", value);
    }

    /// <summary>
    /// <para>Time zone code that was in use when the record was created.</para>
    /// <para>Display Name: UTC Conversion Time Zone Code</para>
    /// </summary>
    [AttributeLogicalName("utcconversiontimezonecode")]
    [DisplayName("UTC Conversion Time Zone Code")]
    [Range(-1, 2147483647)]
    public int? UTCConversionTimeZoneCode
    {
        get => GetAttributeValue<int?>("utcconversiontimezonecode");
        set => SetAttributeValue("utcconversiontimezonecode", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Value Schema</para>
    /// </summary>
    [AttributeLogicalName("valueschema")]
    [DisplayName("Value Schema")]
    [MaxLength(2000)]
    public string? ValueSchema
    {
        get => GetAttributeValue<string?>("valueschema");
        set => SetAttributeValue("valueschema", value);
    }

    /// <summary>
    /// <para>Version Number</para>
    /// <para>Display Name: Version Number</para>
    /// </summary>
    [AttributeLogicalName("versionnumber")]
    [DisplayName("Version Number")]
    public long? VersionNumber
    {
        get => GetAttributeValue<long?>("versionnumber");
        set => SetAttributeValue("versionnumber", value);
    }

    [AttributeLogicalName("parentdefinitionid")]
    [RelationshipSchemaName("envdefinition_envdefinition")]
    [RelationshipMetadata("ManyToOne", "parentdefinitionid", "environmentvariabledefinition", "environmentvariabledefinitionid", "Referencing")]
    public EnvironmentVariableDefinition envdefinition_envdefinition
    {
        get => GetRelatedEntity<EnvironmentVariableDefinition>("envdefinition_envdefinition", null);
        set => SetRelatedEntity("envdefinition_envdefinition", null, value);
    }

    [RelationshipSchemaName("environmentvariabledefinition_environmentvariablevalue")]
    [RelationshipMetadata("OneToMany", "environmentvariabledefinitionid", "environmentvariablevalue", "environmentvariabledefinitionid", "Referenced")]
    public IEnumerable<EnvironmentVariableValue> environmentvariabledefinition_environmentvariablevalue
    {
        get => GetRelatedEntities<EnvironmentVariableValue>("environmentvariabledefinition_environmentvariablevalue", null);
        set => SetRelatedEntities("environmentvariabledefinition_environmentvariablevalue", null, value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariabledefinition_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariabledefinition_createdby", null);
        set => SetRelatedEntity("lk_environmentvariabledefinition_createdby", null, value);
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariabledefinition_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariabledefinition_createdonbehalfby", null);
        set => SetRelatedEntity("lk_environmentvariabledefinition_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariabledefinition_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariabledefinition_modifiedby", null);
        set => SetRelatedEntity("lk_environmentvariabledefinition_modifiedby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariabledefinition_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariabledefinition_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_environmentvariabledefinition_modifiedonbehalfby", null, value);
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_environmentvariabledefinition")]
    [RelationshipMetadata("ManyToOne", "owninguser", "systemuser", "systemuserid", "Referencing")]
    public SystemUser user_environmentvariabledefinition
    {
        get => GetRelatedEntity<SystemUser>("user_environmentvariabledefinition", null);
        set => SetRelatedEntity("user_environmentvariabledefinition", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the EnvironmentVariableDefinition entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<EnvironmentVariableDefinition, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the EnvironmentVariableDefinition with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of EnvironmentVariableDefinition to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved EnvironmentVariableDefinition</returns>
    public static EnvironmentVariableDefinition Retrieve(IOrganizationService service, Guid id, params Expression<Func<EnvironmentVariableDefinition, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }

    /// <summary>
    /// Retrieves the EnvironmentVariableDefinition using the Environment Variable Definition Key alternate key.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="OverwriteTime">OverwriteTime key value</param>
    /// <param name="ComponentState">ComponentState key value</param>
    /// <param name="SchemaName">SchemaName key value</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved EnvironmentVariableDefinition</returns>
    public static EnvironmentVariableDefinition Retrieve_DefinitionKey(IOrganizationService service, DateTime OverwriteTime, componentstate ComponentState, string SchemaName, params Expression<Func<EnvironmentVariableDefinition, object?>>[] columns)
    {
        var keyedEntityReference = new EntityReference(EntityLogicalName, new KeyAttributeCollection
        {
            ["overwritetime"] = OverwriteTime,
            ["componentstate"] = ComponentState,
            ["schemaname"] = SchemaName,
        });

        return service.Retrieve(keyedEntityReference, columns);
    }
}
