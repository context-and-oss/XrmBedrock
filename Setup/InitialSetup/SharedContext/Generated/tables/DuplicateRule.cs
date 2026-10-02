using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>Rule used to identify potential duplicates.</para>
/// <para>Display Name: Duplicate Detection Rule</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("duplicaterule")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class DuplicateRule : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "duplicaterule";
    public const int EntityTypeCode = 4414;

    public DuplicateRule() : base(EntityLogicalName) { }
    public DuplicateRule(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("name");

    [AttributeLogicalName("duplicateruleid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("duplicateruleid", value);
        }
    }

    /// <summary>
    /// <para>Database table that stores match codes for the record type being evaluated for potential duplicates.</para>
    /// <para>Display Name: Base Record Type Match Code Table</para>
    /// </summary>
    [AttributeLogicalName("baseentitymatchcodetable")]
    [DisplayName("Base Record Type Match Code Table")]
    [MaxLength(50)]
    public string? BaseEntityMatchCodeTable
    {
        get => GetAttributeValue<string?>("baseentitymatchcodetable");
        set => SetAttributeValue("baseentitymatchcodetable", value);
    }

    /// <summary>
    /// <para>Record type of the record being evaluated for potential duplicates.</para>
    /// <para>Display Name: Base Record Type</para>
    /// </summary>
    [AttributeLogicalName("baseentityname")]
    [DisplayName("Base Record Type")]
    [MaxLength(160)]
    public string? BaseEntityName
    {
        get => GetAttributeValue<string?>("baseentityname");
        set => SetAttributeValue("baseentityname", value);
    }

    /// <summary>
    /// <para>Record type of the record being evaluated for potential duplicates.</para>
    /// <para>Display Name: Base Record Type</para>
    /// </summary>
    [AttributeLogicalName("baseentitytypecode")]
    [DisplayName("Base Record Type")]
    public duplicaterule_baseentitytypecode? BaseEntityTypeCode
    {
        get => this.GetOptionSetValue<duplicaterule_baseentitytypecode>("baseentitytypecode");
        set => this.SetOptionSetValue("baseentitytypecode", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Row id unique</para>
    /// </summary>
    [AttributeLogicalName("componentidunique")]
    [DisplayName("Row id unique")]
    public Guid? ComponentIdUnique
    {
        get => GetAttributeValue<Guid?>("componentidunique");
        set => SetAttributeValue("componentidunique", value);
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
    /// <para>Unique identifier of the user who created the duplicate detection rule.</para>
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
    /// <para>Date and time when the duplicate detection rule was created.</para>
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
    /// <para>Unique identifier of the delegate user who created the duplicaterule.</para>
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
    /// <para>Description of the duplicate detection rule.</para>
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
    /// <para>Display Name: Duplicate Detection Rule</para>
    /// </summary>
    [AttributeLogicalName("duplicateruleid")]
    [DisplayName("Duplicate Detection Rule")]
    public Guid? DuplicateRuleId
    {
        get => GetAttributeValue<Guid?>("duplicateruleid");
        set => SetId("duplicateruleid", value);
    }

    /// <summary>
    /// <para>Determines whether to flag inactive records as duplicates</para>
    /// <para>Display Name: Exclude Inactive Records</para>
    /// </summary>
    [AttributeLogicalName("excludeinactiverecords")]
    [DisplayName("Exclude Inactive Records")]
    public bool? ExcludeInactiveRecords
    {
        get => GetAttributeValue<bool?>("excludeinactiverecords");
        set => SetAttributeValue("excludeinactiverecords", value);
    }

    /// <summary>
    /// <para>Indicates if the operator is case-sensitive.</para>
    /// <para>Display Name: Case Sensitive</para>
    /// </summary>
    [AttributeLogicalName("iscasesensitive")]
    [DisplayName("Case Sensitive")]
    public bool? IsCaseSensitive
    {
        get => GetAttributeValue<bool?>("iscasesensitive");
        set => SetAttributeValue("iscasesensitive", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Is Customizable</para>
    /// </summary>
    [AttributeLogicalName("iscustomizable")]
    [DisplayName("Is Customizable")]
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
    /// <para>Database table that stores match codes for potential duplicate records.</para>
    /// <para>Display Name: Matching Record Type Match Code Table</para>
    /// </summary>
    [AttributeLogicalName("matchingentitymatchcodetable")]
    [DisplayName("Matching Record Type Match Code Table")]
    [MaxLength(50)]
    public string? MatchingEntityMatchCodeTable
    {
        get => GetAttributeValue<string?>("matchingentitymatchcodetable");
        set => SetAttributeValue("matchingentitymatchcodetable", value);
    }

    /// <summary>
    /// <para>Record type of the records being evaluated as potential duplicates.</para>
    /// <para>Display Name: Matching Record Type</para>
    /// </summary>
    [AttributeLogicalName("matchingentityname")]
    [DisplayName("Matching Record Type")]
    [MaxLength(160)]
    public string? MatchingEntityName
    {
        get => GetAttributeValue<string?>("matchingentityname");
        set => SetAttributeValue("matchingentityname", value);
    }

    /// <summary>
    /// <para>Record type of the records being evaluated as potential duplicates.</para>
    /// <para>Display Name: Matching Record Type</para>
    /// </summary>
    [AttributeLogicalName("matchingentitytypecode")]
    [DisplayName("Matching Record Type")]
    public duplicaterule_matchingentitytypecode? MatchingEntityTypeCode
    {
        get => this.GetOptionSetValue<duplicaterule_matchingentitytypecode>("matchingentitytypecode");
        set => this.SetOptionSetValue("matchingentitytypecode", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who last modified the duplicate detection rule.</para>
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
    /// <para>Date and time when the duplicate detection rule was last modified.</para>
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
    /// <para>Unique identifier of the delegate user who last modified the duplicaterule.</para>
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
    /// <para>Name of the duplicate detection rule.</para>
    /// <para>Display Name: Rule Name</para>
    /// </summary>
    [AttributeLogicalName("name")]
    [DisplayName("Rule Name")]
    [MaxLength(160)]
    public string? Name
    {
        get => GetAttributeValue<string?>("name");
        set => SetAttributeValue("name", value);
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
    /// <para>Unique identifier of the user or team who owns the duplicate detection rule.</para>
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
    /// <para>Unique identifier of the business unit that owns duplicate detection rule.</para>
    /// <para>Display Name: owningbusinessunit</para>
    /// </summary>
    [AttributeLogicalName("owningbusinessunit")]
    [DisplayName("owningbusinessunit")]
    public EntityReference? OwningBusinessUnit
    {
        get => GetAttributeValue<EntityReference?>("owningbusinessunit");
        set => SetAttributeValue("owningbusinessunit", value);
    }

    /// <summary>
    /// <para>Unique identifier of the team who owns the duplicate detection rule.</para>
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
    /// <para>Unique identifier of the user who owns the duplicate detection rule.</para>
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
    /// <para>Status of the duplicate detection rule.</para>
    /// <para>Display Name: Status</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Status")]
    public duplicaterule_statecode? StateCode
    {
        get => this.GetOptionSetValue<duplicaterule_statecode>("statecode");
        set => this.SetOptionSetValue("statecode", value);
    }

    /// <summary>
    /// <para>Reason for the status of the duplicate detection rule.</para>
    /// <para>Display Name: Status Reason</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Status Reason")]
    public duplicaterule_statuscode? StatusCode
    {
        get => this.GetOptionSetValue<duplicaterule_statuscode>("statuscode");
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
    /// <para>Display Name: timezoneruleversionnumber</para>
    /// </summary>
    [AttributeLogicalName("timezoneruleversionnumber")]
    [DisplayName("timezoneruleversionnumber")]
    [Range(-1, 2147483647)]
    public int? TimeZoneRuleVersionNumber
    {
        get => GetAttributeValue<int?>("timezoneruleversionnumber");
        set => SetAttributeValue("timezoneruleversionnumber", value);
    }

    /// <summary>
    /// <para>Display Name: UniqueName</para>
    /// </summary>
    [AttributeLogicalName("uniquename")]
    [DisplayName("UniqueName")]
    [MaxLength(100)]
    public string? UniqueName
    {
        get => GetAttributeValue<string?>("uniquename");
        set => SetAttributeValue("uniquename", value);
    }

    /// <summary>
    /// <para>Time zone code that was in use when the record was created.</para>
    /// <para>Display Name: utcconversiontimezonecode</para>
    /// </summary>
    [AttributeLogicalName("utcconversiontimezonecode")]
    [DisplayName("utcconversiontimezonecode")]
    [Range(-1, 2147483647)]
    public int? UTCConversionTimeZoneCode
    {
        get => GetAttributeValue<int?>("utcconversiontimezonecode");
        set => SetAttributeValue("utcconversiontimezonecode", value);
    }

    [RelationshipSchemaName("DuplicateRule_Annotation")]
    [RelationshipMetadata("OneToMany", "duplicateruleid", "annotation", "objectid", "Referenced")]
    public IEnumerable<Annotation> DuplicateRule_Annotation
    {
        get => GetRelatedEntities<Annotation>("DuplicateRule_Annotation", null);
        set => SetRelatedEntities("DuplicateRule_Annotation", null, value);
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_duplicaterule_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_duplicaterule_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_duplicaterule_createdonbehalfby", null);
        set => SetRelatedEntity("lk_duplicaterule_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_duplicaterule_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_duplicaterule_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_duplicaterule_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_duplicaterule_modifiedonbehalfby", null, value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_duplicaterulebase_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_duplicaterulebase_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_duplicaterulebase_createdby", null);
        set => SetRelatedEntity("lk_duplicaterulebase_createdby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_duplicaterulebase_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_duplicaterulebase_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_duplicaterulebase_modifiedby", null);
        set => SetRelatedEntity("lk_duplicaterulebase_modifiedby", null, value);
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_DuplicateRules")]
    [RelationshipMetadata("ManyToOne", "owninguser", "systemuser", "systemuserid", "Referencing")]
    public SystemUser SystemUser_DuplicateRules
    {
        get => GetRelatedEntity<SystemUser>("SystemUser_DuplicateRules", null);
        set => SetRelatedEntity("SystemUser_DuplicateRules", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the DuplicateRule entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<DuplicateRule, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the DuplicateRule with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of DuplicateRule to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved DuplicateRule</returns>
    public static DuplicateRule Retrieve(IOrganizationService service, Guid id, params Expression<Func<DuplicateRule, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }

    /// <summary>
    /// Retrieves the DuplicateRule using the dupdetectionuniquekey alternate key.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="ComponentState">ComponentState key value</param>
    /// <param name="OverwriteTime">OverwriteTime key value</param>
    /// <param name="UniqueName">UniqueName key value</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved DuplicateRule</returns>
    public static DuplicateRule Retrieve_dupdetectionuniquekey(IOrganizationService service, componentstate ComponentState, DateTime OverwriteTime, string UniqueName, params Expression<Func<DuplicateRule, object?>>[] columns)
    {
        var keyedEntityReference = new EntityReference(EntityLogicalName, new KeyAttributeCollection
        {
            ["componentstate"] = ComponentState,
            ["overwritetime"] = OverwriteTime,
            ["uniquename"] = UniqueName,
        });

        return service.Retrieve(keyedEntityReference, columns);
    }
}
