using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>Saved query against the database.</para>
/// <para>Display Name: View</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("savedquery")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class SavedQuery : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "savedquery";
    public const int EntityTypeCode = 1039;

    public SavedQuery() : base(EntityLogicalName) { }
    public SavedQuery(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("name");

    [AttributeLogicalName("savedqueryid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("savedqueryid", value);
        }
    }

    /// <summary>
    /// <para>Type the column name that will be used to group the results from the data collected across multiple records from a system view.</para>
    /// <para>Display Name: Advanced Group By</para>
    /// </summary>
    [AttributeLogicalName("advancedgroupby")]
    [DisplayName("Advanced Group By")]
    [MaxLength(2000)]
    public string? AdvancedGroupBy
    {
        get => GetAttributeValue<string?>("advancedgroupby");
        set => SetAttributeValue("advancedgroupby", value);
    }

    /// <summary>
    /// <para>Tells whether the view can be deleted.</para>
    /// <para>Display Name: Can Be Deleted</para>
    /// </summary>
    [AttributeLogicalName("canbedeleted")]
    [DisplayName("Can Be Deleted")]
    public BooleanManagedProperty CanBeDeleted
    {
        get => GetAttributeValue<BooleanManagedProperty>("canbedeleted");
        set => SetAttributeValue("canbedeleted", value);
    }

    /// <summary>
    /// <para>Contains the columns and sorting criteria for the view, stored in XML format.</para>
    /// <para>Display Name: Column Set XML</para>
    /// </summary>
    [AttributeLogicalName("columnsetxml")]
    [DisplayName("Column Set XML")]
    [MaxLength(1073741823)]
    public string? ColumnSetXml
    {
        get => GetAttributeValue<string?>("columnsetxml");
        set => SetAttributeValue("columnsetxml", value);
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
    /// <para>Type information about how the items in the system view are formatted.</para>
    /// <para>Display Name: Conditional formatting</para>
    /// </summary>
    [AttributeLogicalName("conditionalformatting")]
    [DisplayName("Conditional formatting")]
    [MaxLength(1073741823)]
    public string? ConditionalFormatting
    {
        get => GetAttributeValue<string?>("conditionalformatting");
        set => SetAttributeValue("conditionalformatting", value);
    }

    /// <summary>
    /// <para>Shows who created the record.</para>
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
    /// <para>Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</para>
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
    /// <para>Shows who created the record on behalf of another user.</para>
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
    /// <para>Type additional information to describe the view, such as the filter criteria or intended results set.</para>
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
    /// <para>Tells whether the view can retrieve data from all cluster partitions.</para>
    /// <para>Display Name: Default</para>
    /// </summary>
    [AttributeLogicalName("enablecrosspartition")]
    [DisplayName("Default")]
    public bool? EnableCrossPartition
    {
        get => GetAttributeValue<bool?>("enablecrosspartition");
        set => SetAttributeValue("enablecrosspartition", value);
    }

    /// <summary>
    /// <para>String specifying the query in Fetch XML language.</para>
    /// <para>Display Name: Fetch XML</para>
    /// </summary>
    [AttributeLogicalName("fetchxml")]
    [DisplayName("Fetch XML")]
    [MaxLength(1073741823)]
    public string? FetchXml
    {
        get => GetAttributeValue<string?>("fetchxml");
        set => SetAttributeValue("fetchxml", value);
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
    /// <para>Tells whether a user created the view.</para>
    /// <para>Display Name: Is Custom</para>
    /// </summary>
    [AttributeLogicalName("iscustom")]
    [DisplayName("Is Custom")]
    public bool? IsCustom
    {
        get => GetAttributeValue<bool?>("iscustom");
        set => SetAttributeValue("iscustom", value);
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
    /// <para>Tells whether the view is the default view for the specified record type (entity).</para>
    /// <para>Display Name: Default</para>
    /// </summary>
    [AttributeLogicalName("isdefault")]
    [DisplayName("Default")]
    public bool? IsDefault
    {
        get => GetAttributeValue<bool?>("isdefault");
        set => SetAttributeValue("isdefault", value);
    }

    /// <summary>
    /// <para>Tells whether the record is part of a managed solution.</para>
    /// <para>Display Name: State</para>
    /// </summary>
    [AttributeLogicalName("ismanaged")]
    [DisplayName("State")]
    public bool? IsManaged
    {
        get => GetAttributeValue<bool?>("ismanaged");
        set => SetAttributeValue("ismanaged", value);
    }

    /// <summary>
    /// <para>Indicates whether or not this is viewable by the entire organization.</para>
    /// <para>Display Name: Is Private</para>
    /// </summary>
    [AttributeLogicalName("isprivate")]
    [DisplayName("Is Private")]
    public bool? IsPrivate
    {
        get => GetAttributeValue<bool?>("isprivate");
        set => SetAttributeValue("isprivate", value);
    }

    /// <summary>
    /// <para>Choose whether the view is compatible with Quick Find. When users search for specific items, you define the fields that are searched in.</para>
    /// <para>Display Name: Quick Find Compatible</para>
    /// </summary>
    [AttributeLogicalName("isquickfindquery")]
    [DisplayName("Quick Find Compatible")]
    public bool? IsQuickFindQuery
    {
        get => GetAttributeValue<bool?>("isquickfindquery");
        set => SetAttributeValue("isquickfindquery", value);
    }

    /// <summary>
    /// <para>Tells whether the view was created by a user.</para>
    /// <para>Display Name: User Defined</para>
    /// </summary>
    [AttributeLogicalName("isuserdefined")]
    [DisplayName("User Defined")]
    public bool? IsUserDefined
    {
        get => GetAttributeValue<bool?>("isuserdefined");
        set => SetAttributeValue("isuserdefined", value);
    }

    /// <summary>
    /// <para>Layout data in JSON format.</para>
    /// <para>Display Name: Layout data in JSON format.</para>
    /// </summary>
    [AttributeLogicalName("layoutjson")]
    [DisplayName("Layout data in JSON format.")]
    [MaxLength(1073741823)]
    public string? LayoutJson
    {
        get => GetAttributeValue<string?>("layoutjson");
        set => SetAttributeValue("layoutjson", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Layout XML</para>
    /// </summary>
    [AttributeLogicalName("layoutxml")]
    [DisplayName("Layout XML")]
    [MaxLength(1073741823)]
    public string? LayoutXml
    {
        get => GetAttributeValue<string?>("layoutxml");
        set => SetAttributeValue("layoutxml", value);
    }

    /// <summary>
    /// <para>Shows who last updated the record.</para>
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
    /// <para>Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</para>
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
    /// <para>Shows who last updated the record on behalf of another user.</para>
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
    /// <para>Type a name for the view to describe what results the view will contain. This name is visible to users in the View list.</para>
    /// <para>Display Name: Name</para>
    /// </summary>
    [AttributeLogicalName("name")]
    [DisplayName("Name")]
    [MaxLength(200)]
    public string? Name
    {
        get => GetAttributeValue<string?>("name");
        set => SetAttributeValue("name", value);
    }

    /// <summary>
    /// <para>String specifying the corresponding sql query for the fetch xml specified for offline use.</para>
    /// <para>Display Name: Offline SQL Query</para>
    /// </summary>
    [AttributeLogicalName("offlinesqlquery")]
    [DisplayName("Offline SQL Query")]
    [MaxLength(1073741823)]
    public string? OfflineSqlQuery
    {
        get => GetAttributeValue<string?>("offlinesqlquery");
        set => SetAttributeValue("offlinesqlquery", value);
    }

    /// <summary>
    /// <para>Choose the ID of the organization that the record is associated with.</para>
    /// <para>Display Name: Organization</para>
    /// </summary>
    [AttributeLogicalName("organizationid")]
    [DisplayName("Organization")]
    public EntityReference? OrganizationId
    {
        get => GetAttributeValue<EntityReference?>("organizationid");
        set => SetAttributeValue("organizationid", value);
    }

    /// <summary>
    /// <para>For the organization, type the tab order to determine how users navigate through the screen using only the Tab key.</para>
    /// <para>Display Name: Default Organization tab order</para>
    /// </summary>
    [AttributeLogicalName("organizationtaborder")]
    [DisplayName("Default Organization tab order")]
    [Range(0, 2147483647)]
    public int? OrganizationTabOrder
    {
        get => GetAttributeValue<int?>("organizationtaborder");
        set => SetAttributeValue("organizationtaborder", value);
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
    /// <para>For internal use only.</para>
    /// <para>Display Name: Query API</para>
    /// </summary>
    [AttributeLogicalName("queryapi")]
    [DisplayName("Query API")]
    [MaxLength(100)]
    public string? QueryAPI
    {
        get => GetAttributeValue<string?>("queryapi");
        set => SetAttributeValue("queryapi", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Query Application Usage</para>
    /// </summary>
    [AttributeLogicalName("queryappusage")]
    [DisplayName("Query Application Usage")]
    [Range(0, 1000000000)]
    public int? QueryAppUsage
    {
        get => GetAttributeValue<int?>("queryappusage");
        set => SetAttributeValue("queryappusage", value);
    }

    /// <summary>
    /// <para>Shows the type of the query.</para>
    /// <para>Display Name: Query Type</para>
    /// </summary>
    [AttributeLogicalName("querytype")]
    [DisplayName("Query Type")]
    [Range(0, 1000000000)]
    public int? QueryType
    {
        get => GetAttributeValue<int?>("querytype");
        set => SetAttributeValue("querytype", value);
    }

    /// <summary>
    /// <para>Type of entity displayed in the view.</para>
    /// <para>Display Name: Entity Name</para>
    /// </summary>
    [AttributeLogicalName("returnedtypecode")]
    [DisplayName("Entity Name")]
    [MaxLength()]
    public string? ReturnedTypeCode
    {
        get => GetAttributeValue<string?>("returnedtypecode");
        set => SetAttributeValue("returnedtypecode", value);
    }

    /// <summary>
    /// <para>Contains the role display conditions for the SavedQuery.</para>
    /// <para>Display Name: Role display conditions for the SavedQuery</para>
    /// </summary>
    [AttributeLogicalName("roledisplayconditionsxml")]
    [DisplayName("Role display conditions for the SavedQuery")]
    [MaxLength(1073741823)]
    public string? RoleDisplayConditionsXml
    {
        get => GetAttributeValue<string?>("roledisplayconditionsxml");
        set => SetAttributeValue("roledisplayconditionsxml", value);
    }

    /// <summary>
    /// <para>Display Name: View</para>
    /// </summary>
    [AttributeLogicalName("savedqueryid")]
    [DisplayName("View")]
    public Guid? SavedQueryId
    {
        get => GetAttributeValue<Guid?>("savedqueryid");
        set => SetId("savedqueryid", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: savedqueryidunique</para>
    /// </summary>
    [AttributeLogicalName("savedqueryidunique")]
    [DisplayName("savedqueryidunique")]
    public Guid? SavedQueryIdUnique
    {
        get => GetAttributeValue<Guid?>("savedqueryidunique");
        set => SetAttributeValue("savedqueryidunique", value);
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
    /// <para>Shows the status of the view.</para>
    /// <para>Display Name: Status</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Status")]
    public savedquery_statecode? StateCode
    {
        get => this.GetOptionSetValue<savedquery_statecode>("statecode");
        set => this.SetOptionSetValue("statecode", value);
    }

    /// <summary>
    /// <para>Shows the reason code that explains the status of the record.</para>
    /// <para>Display Name: Status Reason</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Status Reason")]
    public savedquery_statuscode? StatusCode
    {
        get => this.GetOptionSetValue<savedquery_statuscode>("statuscode");
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
    /// <para>Version number of the view.</para>
    /// <para>Display Name: Version Number</para>
    /// </summary>
    [AttributeLogicalName("versionnumber")]
    [DisplayName("Version Number")]
    public long? VersionNumber
    {
        get => GetAttributeValue<long?>("versionnumber");
        set => SetAttributeValue("versionnumber", value);
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_savedquery_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_savedquery_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_savedquery_createdonbehalfby", null);
        set => SetRelatedEntity("lk_savedquery_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_savedquery_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_savedquery_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_savedquery_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_savedquery_modifiedonbehalfby", null, value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_savedquerybase_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_savedquerybase_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_savedquerybase_createdby", null);
        set => SetRelatedEntity("lk_savedquerybase_createdby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_savedquerybase_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_savedquerybase_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_savedquerybase_modifiedby", null);
        set => SetRelatedEntity("lk_savedquerybase_modifiedby", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the SavedQuery entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<SavedQuery, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the SavedQuery with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of SavedQuery to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved SavedQuery</returns>
    public static SavedQuery Retrieve(IOrganizationService service, Guid id, params Expression<Func<SavedQuery, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }
}
