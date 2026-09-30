using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>Holds the value for the associated EnvironmentVariableDefinition entity.</para>
/// <para>Display Name: Environment Variable Value</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("environmentvariablevalue")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class EnvironmentVariableValue : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "environmentvariablevalue";
    public const int EntityTypeCode = 381;

    public EnvironmentVariableValue() : base(EntityLogicalName) { }
    public EnvironmentVariableValue(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("schemaname");

    [AttributeLogicalName("environmentvariablevalueid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("environmentvariablevalueid", value);
        }
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
    /// <para>Unique identifier for Environment Variable Definition associated with Environment Variable Value.</para>
    /// <para>Display Name: Environment Variable Definition</para>
    /// </summary>
    [AttributeLogicalName("environmentvariabledefinitionid")]
    [DisplayName("Environment Variable Definition")]
    public EntityReference? EnvironmentVariableDefinitionId
    {
        get => GetAttributeValue<EntityReference?>("environmentvariabledefinitionid");
        set => SetAttributeValue("environmentvariabledefinitionid", value);
    }

    /// <summary>
    /// <para>Display Name: Environment Variable Value</para>
    /// </summary>
    [AttributeLogicalName("environmentvariablevalueid")]
    [DisplayName("Environment Variable Value")]
    public Guid? EnvironmentVariableValueId
    {
        get => GetAttributeValue<Guid?>("environmentvariablevalueid");
        set => SetId("environmentvariablevalueid", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: environmentvariablevalueidunique</para>
    /// </summary>
    [AttributeLogicalName("environmentvariablevalueidunique")]
    [DisplayName("environmentvariablevalueidunique")]
    public Guid? EnvironmentVariableValueIdUnique
    {
        get => GetAttributeValue<Guid?>("environmentvariablevalueidunique");
        set => SetAttributeValue("environmentvariablevalueidunique", value);
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
    /// <para>Status of the Environment Variable Value</para>
    /// <para>Display Name: Status</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Status")]
    public environmentvariablevalue_statecode? statecode
    {
        get => this.GetOptionSetValue<environmentvariablevalue_statecode>("statecode");
        set => this.SetOptionSetValue("statecode", value);
    }

    /// <summary>
    /// <para>Reason for the status of the Environment Variable Value</para>
    /// <para>Display Name: Status Reason</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Status Reason")]
    public environmentvariablevalue_statuscode? statuscode
    {
        get => this.GetOptionSetValue<environmentvariablevalue_statuscode>("statuscode");
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
    /// <para>Contains the actual variable data.</para>
    /// <para>Display Name: Value</para>
    /// </summary>
    [AttributeLogicalName("value")]
    [DisplayName("Value")]
    [MaxLength(2000)]
    public string? Value
    {
        get => GetAttributeValue<string?>("value");
        set => SetAttributeValue("value", value);
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

    [AttributeLogicalName("environmentvariabledefinitionid")]
    [RelationshipSchemaName("environmentvariabledefinition_environmentvariablevalue")]
    [RelationshipMetadata("ManyToOne", "environmentvariabledefinitionid", "environmentvariabledefinition", "environmentvariabledefinitionid", "Referencing")]
    public EnvironmentVariableDefinition environmentvariabledefinition_environmentvariablevalue
    {
        get => GetRelatedEntity<EnvironmentVariableDefinition>("environmentvariabledefinition_environmentvariablevalue", null);
        set => SetRelatedEntity("environmentvariabledefinition_environmentvariablevalue", null, value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariablevalue_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_createdby", null);
        set => SetRelatedEntity("lk_environmentvariablevalue_createdby", null, value);
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariablevalue_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_createdonbehalfby", null);
        set => SetRelatedEntity("lk_environmentvariablevalue_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariablevalue_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_modifiedby", null);
        set => SetRelatedEntity("lk_environmentvariablevalue_modifiedby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_environmentvariablevalue_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_environmentvariablevalue_modifiedonbehalfby", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the EnvironmentVariableValue entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<EnvironmentVariableValue, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the EnvironmentVariableValue with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of EnvironmentVariableValue to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved EnvironmentVariableValue</returns>
    public static EnvironmentVariableValue Retrieve(IOrganizationService service, Guid id, params Expression<Func<EnvironmentVariableValue, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }

    /// <summary>
    /// Retrieves the EnvironmentVariableValue using the Environmentvariable Definition Id Key alternate key.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="ComponentState">ComponentState key value</param>
    /// <param name="EnvironmentVariableDefinitionId">EnvironmentVariableDefinitionId key value</param>
    /// <param name="OverwriteTime">OverwriteTime key value</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved EnvironmentVariableValue</returns>
    public static EnvironmentVariableValue Retrieve_EnvironmentvariableDefinitionIdKey(IOrganizationService service, componentstate ComponentState, Guid EnvironmentVariableDefinitionId, DateTime OverwriteTime, params Expression<Func<EnvironmentVariableValue, object?>>[] columns)
    {
        var keyedEntityReference = new EntityReference(EntityLogicalName, new KeyAttributeCollection
        {
            ["componentstate"] = ComponentState,
            ["environmentvariabledefinitionid"] = EnvironmentVariableDefinitionId,
            ["overwritetime"] = OverwriteTime,
        });

        return service.Retrieve(keyedEntityReference, columns);
    }
}
