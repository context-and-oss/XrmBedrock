using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>Notification to be provided to a user.</para>
/// <para>Display Name: Notification</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("appnotification")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class appnotification : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "appnotification";
    public const int EntityTypeCode = 10333;

    public appnotification() : base(EntityLogicalName) { }
    public appnotification(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("title");

    [AttributeLogicalName("appnotificationid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("appnotificationid", value);
        }
    }

    /// <summary>
    /// <para>This field is not used</para>
    /// <para>Display Name: Model-driven app</para>
    /// </summary>
    [AttributeLogicalName("appmoduleid")]
    [DisplayName("Model-driven app")]
    public EntityReference? AppModuleId
    {
        get => GetAttributeValue<EntityReference?>("appmoduleid");
        set => SetAttributeValue("appmoduleid", value);
    }

    /// <summary>
    /// <para>Display Name: Notification</para>
    /// </summary>
    [AttributeLogicalName("appnotificationid")]
    [DisplayName("Notification")]
    public Guid? appnotificationId
    {
        get => GetAttributeValue<Guid?>("appnotificationid");
        set => SetId("appnotificationid", value);
    }

    /// <summary>
    /// <para>Body of the notification</para>
    /// <para>Display Name: Body</para>
    /// </summary>
    [AttributeLogicalName("body")]
    [DisplayName("Body")]
    [MaxLength(500)]
    public string? Body
    {
        get => GetAttributeValue<string?>("body");
        set => SetAttributeValue("body", value);
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
    /// <para>Custom data for the notification that can be used by the notification card</para>
    /// <para>Display Name: Data</para>
    /// </summary>
    [AttributeLogicalName("data")]
    [DisplayName("Data")]
    [MaxLength(5000)]
    public string? Data
    {
        get => GetAttributeValue<string?>("data");
        set => SetAttributeValue("data", value);
    }

    /// <summary>
    /// <para>Display Name: IconType</para>
    /// </summary>
    [AttributeLogicalName("icontype")]
    [DisplayName("IconType")]
    public notification_iconid? IconType
    {
        get => this.GetOptionSetValue<notification_iconid>("icontype");
        set => this.SetOptionSetValue("icontype", value);
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
    /// <para>Partitioning will be based on owner and it is recommended to specify this field for all operations for performance reason</para>
    /// <para>Display Name: Partition Id</para>
    /// </summary>
    [AttributeLogicalName("partitionid")]
    [DisplayName("Partition Id")]
    [MaxLength(100)]
    public string? PartitionId
    {
        get => GetAttributeValue<string?>("partitionid");
        set => SetAttributeValue("partitionid", value);
    }

    /// <summary>
    /// <para>Priority of the notification</para>
    /// <para>Display Name: Priority</para>
    /// </summary>
    [AttributeLogicalName("priority")]
    [DisplayName("Priority")]
    public notification_priority? Priority
    {
        get => this.GetOptionSetValue<notification_priority>("priority");
        set => this.SetOptionSetValue("priority", value);
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
    /// <para>Title for the notification</para>
    /// <para>Display Name: Title</para>
    /// </summary>
    [AttributeLogicalName("title")]
    [DisplayName("Title")]
    [MaxLength(256)]
    public string? Title
    {
        get => GetAttributeValue<string?>("title");
        set => SetAttributeValue("title", value);
    }

    /// <summary>
    /// <para>Type of toast behavior for the notification</para>
    /// <para>Display Name: Toast Type</para>
    /// </summary>
    [AttributeLogicalName("toasttype")]
    [DisplayName("Toast Type")]
    public notification_toasttype? ToastType
    {
        get => this.GetOptionSetValue<notification_toasttype>("toasttype");
        set => this.SetOptionSetValue("toasttype", value);
    }

    /// <summary>
    /// <para>After the specified number of seconds the notification will be deleted</para>
    /// <para>Display Name: Expiry (seconds)</para>
    /// </summary>
    [AttributeLogicalName("ttlinseconds")]
    [DisplayName("Expiry (seconds)")]
    [Range(1, 2147483647)]
    public int? TTLInSeconds
    {
        get => GetAttributeValue<int?>("ttlinseconds");
        set => SetAttributeValue("ttlinseconds", value);
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

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appnotification_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_appnotification_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_appnotification_createdby", null);
        set => SetRelatedEntity("lk_appnotification_createdby", null, value);
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appnotification_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_appnotification_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_appnotification_createdonbehalfby", null);
        set => SetRelatedEntity("lk_appnotification_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appnotification_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_appnotification_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_appnotification_modifiedby", null);
        set => SetRelatedEntity("lk_appnotification_modifiedby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appnotification_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_appnotification_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_appnotification_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_appnotification_modifiedonbehalfby", null, value);
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_appnotification")]
    [RelationshipMetadata("ManyToOne", "owninguser", "systemuser", "systemuserid", "Referencing")]
    public SystemUser user_appnotification
    {
        get => GetRelatedEntity<SystemUser>("user_appnotification", null);
        set => SetRelatedEntity("user_appnotification", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the appnotification entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<appnotification, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the appnotification with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of appnotification to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved appnotification</returns>
    public static appnotification Retrieve(IOrganizationService service, Guid id, params Expression<Func<appnotification, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }

    /// <summary>
    /// Retrieves the appnotification using the Entity key for NoSql Entity that contains PrimaryKey and PartitionId attributes alternate key.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="appnotificationId">appnotificationId key value</param>
    /// <param name="PartitionId">PartitionId key value</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved appnotification</returns>
    public static appnotification Retrieve_KeyForNoSqlEntityWithPKPartitionId(IOrganizationService service, Guid appnotificationId, string PartitionId, params Expression<Func<appnotification, object?>>[] columns)
    {
        var keyedEntityReference = new EntityReference(EntityLogicalName, new KeyAttributeCollection
        {
            ["appnotificationid"] = appnotificationId,
            ["partitionid"] = PartitionId,
        });

        return service.Retrieve(keyedEntityReference, columns);
    }
}
