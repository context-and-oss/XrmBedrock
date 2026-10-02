using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>A list of records that require action, such as accounts, activities, and cases.</para>
/// <para>Display Name: Queue</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("queue")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class Queue : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "queue";
    public const int EntityTypeCode = 2020;

    public Queue() : base(EntityLogicalName) { }
    public Queue(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("name");

    [AttributeLogicalName("queueid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("queueid", value);
        }
    }

    /// <summary>
    /// <para>This attribute is no longer used. The data is now in the Mailbox.AllowEmailConnectorToUseCredentials attribute.</para>
    /// <para>Display Name: Allow to Use Credentials for Email Processing (Obsolete)</para>
    /// </summary>
    [AttributeLogicalName("allowemailcredentials")]
    [DisplayName("Allow to Use Credentials for Email Processing (Obsolete)")]
    public bool? AllowEmailCredentials
    {
        get => GetAttributeValue<bool?>("allowemailcredentials");
        set => SetAttributeValue("allowemailcredentials", value);
    }

    /// <summary>
    /// <para>Unique identifier of the business unit with which the queue is associated.</para>
    /// <para>Display Name: Business Unit</para>
    /// </summary>
    [AttributeLogicalName("businessunitid")]
    [DisplayName("Business Unit")]
    public EntityReference? BusinessUnitId
    {
        get => GetAttributeValue<EntityReference?>("businessunitid");
        set => SetAttributeValue("businessunitid", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who created the queue record.</para>
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
    /// <para>Date and time when the queue was created.</para>
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
    /// <para>Unique identifier of the delegate user who created the queue.</para>
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
    /// <para>Select the mailbox associated with this queue.</para>
    /// <para>Display Name: Mailbox</para>
    /// </summary>
    [AttributeLogicalName("defaultmailbox")]
    [DisplayName("Mailbox")]
    public EntityReference? DefaultMailbox
    {
        get => GetAttributeValue<EntityReference?>("defaultmailbox");
        set => SetAttributeValue("defaultmailbox", value);
    }

    /// <summary>
    /// <para>Description of the queue.</para>
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
    /// <para>Email address that is associated with the queue.</para>
    /// <para>Display Name: Incoming Email</para>
    /// </summary>
    [AttributeLogicalName("emailaddress")]
    [DisplayName("Incoming Email")]
    [MaxLength(100)]
    public string? EMailAddress
    {
        get => GetAttributeValue<string?>("emailaddress");
        set => SetAttributeValue("emailaddress", value);
    }

    /// <summary>
    /// <para>This attribute is no longer used. The data is now in the Mailbox.Password attribute.</para>
    /// <para>Display Name: Password (Obsolete)</para>
    /// </summary>
    [AttributeLogicalName("emailpassword")]
    [DisplayName("Password (Obsolete)")]
    [MaxLength(200)]
    public string? EmailPassword
    {
        get => GetAttributeValue<string?>("emailpassword");
        set => SetAttributeValue("emailpassword", value);
    }

    /// <summary>
    /// <para>Shows the status of the primary email address.</para>
    /// <para>Display Name: Primary Email Status</para>
    /// </summary>
    [AttributeLogicalName("emailrouteraccessapproval")]
    [DisplayName("Primary Email Status")]
    public queue_emailrouteraccessapproval? EmailRouterAccessApproval
    {
        get => this.GetOptionSetValue<queue_emailrouteraccessapproval>("emailrouteraccessapproval");
        set => this.SetOptionSetValue("emailrouteraccessapproval", value);
    }

    /// <summary>
    /// <para>This attribute is no longer used. The data is now in the Mailbox.UserName attribute.</para>
    /// <para>Display Name: User Name (Obsolete)</para>
    /// </summary>
    [AttributeLogicalName("emailusername")]
    [DisplayName("User Name (Obsolete)")]
    [MaxLength(200)]
    public string? EmailUsername
    {
        get => GetAttributeValue<string?>("emailusername");
        set => SetAttributeValue("emailusername", value);
    }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Entity Image Id</para>
    /// </summary>
    [AttributeLogicalName("entityimageid")]
    [DisplayName("Entity Image Id")]
    public Guid? EntityImageId
    {
        get => GetAttributeValue<Guid?>("entityimageid");
        set => SetAttributeValue("entityimageid", value);
    }

    /// <summary>
    /// <para>Exchange rate for the currency associated with the queue with respect to the base currency.</para>
    /// <para>Display Name: Exchange Rate</para>
    /// </summary>
    [AttributeLogicalName("exchangerate")]
    [DisplayName("Exchange Rate")]
    public decimal? ExchangeRate
    {
        get => GetAttributeValue<decimal?>("exchangerate");
        set => SetAttributeValue("exchangerate", value);
    }

    /// <summary>
    /// <para>Information that specifies whether a queue is to ignore unsolicited email (deprecated).</para>
    /// <para>Display Name: Convert To Email Activities</para>
    /// </summary>
    [AttributeLogicalName("ignoreunsolicitedemail")]
    [DisplayName("Convert To Email Activities")]
    public bool? IgnoreUnsolicitedEmail
    {
        get => GetAttributeValue<bool?>("ignoreunsolicitedemail");
        set => SetAttributeValue("ignoreunsolicitedemail", value);
    }

    /// <summary>
    /// <para>Unique identifier of the data import or data migration that created this record.</para>
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
    /// <para>Incoming email delivery method for the queue.</para>
    /// <para>Display Name: Incoming Email Delivery Method</para>
    /// </summary>
    [AttributeLogicalName("incomingemaildeliverymethod")]
    [DisplayName("Incoming Email Delivery Method")]
    public queue_incomingemaildeliverymethod? IncomingEmailDeliveryMethod
    {
        get => this.GetOptionSetValue<queue_incomingemaildeliverymethod>("incomingemaildeliverymethod");
        set => this.SetOptionSetValue("incomingemaildeliverymethod", value);
    }

    /// <summary>
    /// <para>Convert Incoming Email To Activities</para>
    /// <para>Display Name: Convert Incoming Email To Activities</para>
    /// </summary>
    [AttributeLogicalName("incomingemailfilteringmethod")]
    [DisplayName("Convert Incoming Email To Activities")]
    public queue_incomingemailfilteringmethod? IncomingEmailFilteringMethod
    {
        get => this.GetOptionSetValue<queue_incomingemailfilteringmethod>("incomingemailfilteringmethod");
        set => this.SetOptionSetValue("incomingemailfilteringmethod", value);
    }

    /// <summary>
    /// <para>Shows the status of approval of the email address by O365 Admin.</para>
    /// <para>Display Name: Email Address O365 Admin Approval Status</para>
    /// </summary>
    [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
    [DisplayName("Email Address O365 Admin Approval Status")]
    public bool? IsEmailAddressApprovedByO365Admin
    {
        get => GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin");
        set => SetAttributeValue("isemailaddressapprovedbyo365admin", value);
    }

    /// <summary>
    /// <para>Indication of whether a queue is the fax delivery queue.</para>
    /// <para>Display Name: Fax Queue</para>
    /// </summary>
    [AttributeLogicalName("isfaxqueue")]
    [DisplayName("Fax Queue")]
    public bool? IsFaxQueue
    {
        get => GetAttributeValue<bool?>("isfaxqueue");
        set => SetAttributeValue("isfaxqueue", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who last modified the queue.</para>
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
    /// <para>Date and time when the queue was last modified.</para>
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
    /// <para>Unique identifier of the delegate user who last modified the queue.</para>
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
    /// <para>Name of the queue.</para>
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
    /// <para>Number of Queue items associated with the queue.</para>
    /// <para>Display Name: Queue Items</para>
    /// </summary>
    [AttributeLogicalName("numberofitems")]
    [DisplayName("Queue Items")]
    [Range(-2147483648, 2147483647)]
    public int? NumberOfItems
    {
        get => GetAttributeValue<int?>("numberofitems");
        set => SetAttributeValue("numberofitems", value);
    }

    /// <summary>
    /// <para>Number of Members associated with the queue.</para>
    /// <para>Display Name: No. of Members</para>
    /// </summary>
    [AttributeLogicalName("numberofmembers")]
    [DisplayName("No. of Members")]
    [Range(-2147483648, 2147483647)]
    public int? NumberOfMembers
    {
        get => GetAttributeValue<int?>("numberofmembers");
        set => SetAttributeValue("numberofmembers", value);
    }

    /// <summary>
    /// <para>Unique identifier of the organization associated with the queue.</para>
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
    /// <para>Outgoing email delivery method for the queue.</para>
    /// <para>Display Name: Outgoing Email Delivery Method</para>
    /// </summary>
    [AttributeLogicalName("outgoingemaildeliverymethod")]
    [DisplayName("Outgoing Email Delivery Method")]
    public queue_outgoingemaildeliverymethod? OutgoingEmailDeliveryMethod
    {
        get => this.GetOptionSetValue<queue_outgoingemaildeliverymethod>("outgoingemaildeliverymethod");
        set => this.SetOptionSetValue("outgoingemaildeliverymethod", value);
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
    /// <para>Unique identifier of the user or team who owns the queue.</para>
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
    /// <para>Unique identifier of the business unit that owns the queue.</para>
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
    /// <para>Unique identifier of the team who owns the queue.</para>
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
    /// <para>Unique identifier of the user who owns the queue.</para>
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
    /// <para>Unique identifier of the owner of the queue.</para>
    /// <para>Display Name: Owner (deprecated)</para>
    /// </summary>
    [AttributeLogicalName("primaryuserid")]
    [DisplayName("Owner (deprecated)")]
    public EntityReference? PrimaryUserId
    {
        get => GetAttributeValue<EntityReference?>("primaryuserid");
        set => SetAttributeValue("primaryuserid", value);
    }

    /// <summary>
    /// <para>Display Name: Queue</para>
    /// </summary>
    [AttributeLogicalName("queueid")]
    [DisplayName("Queue")]
    public Guid? QueueId
    {
        get => GetAttributeValue<Guid?>("queueid");
        set => SetId("queueid", value);
    }

    /// <summary>
    /// <para>Type of queue that is automatically assigned when a user or queue is created. The type can be public, private, or work in process.</para>
    /// <para>Display Name: Queue Type</para>
    /// </summary>
    [AttributeLogicalName("queuetypecode")]
    [DisplayName("Queue Type")]
    public queue_queuetypecode? QueueTypeCode
    {
        get => this.GetOptionSetValue<queue_queuetypecode>("queuetypecode");
        set => this.SetOptionSetValue("queuetypecode", value);
    }

    /// <summary>
    /// <para>Select whether the queue is public or private. A public queue can be viewed by all. A private queue can be viewed only by the members added to the queue.</para>
    /// <para>Display Name: Type</para>
    /// </summary>
    [AttributeLogicalName("queueviewtype")]
    [DisplayName("Type")]
    public queue_queueviewtype? QueueViewType
    {
        get => this.GetOptionSetValue<queue_queueviewtype>("queueviewtype");
        set => this.SetOptionSetValue("queueviewtype", value);
    }

    /// <summary>
    /// <para>Status of the queue.</para>
    /// <para>Display Name: Status</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Status")]
    public queue_statecode? StateCode
    {
        get => this.GetOptionSetValue<queue_statecode>("statecode");
        set => this.SetOptionSetValue("statecode", value);
    }

    /// <summary>
    /// <para>Reason for the status of the queue.</para>
    /// <para>Display Name: Status Reason</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Status Reason")]
    public queue_statuscode? StatusCode
    {
        get => this.GetOptionSetValue<queue_statuscode>("statuscode");
        set => this.SetOptionSetValue("statuscode", value);
    }

    /// <summary>
    /// <para>Unique identifier of the currency associated with the queue.</para>
    /// <para>Display Name: Currency</para>
    /// </summary>
    [AttributeLogicalName("transactioncurrencyid")]
    [DisplayName("Currency")]
    public EntityReference? TransactionCurrencyId
    {
        get => GetAttributeValue<EntityReference?>("transactioncurrencyid");
        set => SetAttributeValue("transactioncurrencyid", value);
    }

    /// <summary>
    /// <para>Version number of the queue.</para>
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
    [RelationshipSchemaName("lk_queue_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_queue_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_queue_createdonbehalfby", null);
        set => SetRelatedEntity("lk_queue_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_queue_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_queue_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_queue_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_queue_modifiedonbehalfby", null, value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_queuebase_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_queuebase_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_queuebase_createdby", null);
        set => SetRelatedEntity("lk_queuebase_createdby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_queuebase_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_queuebase_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_queuebase_modifiedby", null);
        set => SetRelatedEntity("lk_queuebase_modifiedby", null, value);
    }

    [RelationshipSchemaName("queue_activity_parties")]
    [RelationshipMetadata("OneToMany", "queueid", "activityparty", "partyid", "Referenced")]
    public IEnumerable<ActivityParty> queue_activity_parties
    {
        get => GetRelatedEntities<ActivityParty>("queue_activity_parties", null);
        set => SetRelatedEntities("queue_activity_parties", null, value);
    }

    [AttributeLogicalName("primaryuserid")]
    [RelationshipSchemaName("queue_primary_user")]
    [RelationshipMetadata("ManyToOne", "primaryuserid", "systemuser", "systemuserid", "Referencing")]
    public SystemUser queue_primary_user
    {
        get => GetRelatedEntity<SystemUser>("queue_primary_user", null);
        set => SetRelatedEntity("queue_primary_user", null, value);
    }

    [RelationshipSchemaName("queue_system_user")]
    [RelationshipMetadata("OneToMany", "queueid", "systemuser", "queueid", "Referenced")]
    public IEnumerable<SystemUser> queue_system_user
    {
        get => GetRelatedEntities<SystemUser>("queue_system_user", null);
        set => SetRelatedEntities("queue_system_user", null, value);
    }

    [RelationshipSchemaName("queuemembership_association")]
    [RelationshipMetadata("ManyToMany", "queueid", "systemuser", "systemuserid", "Entity1")]
    public IEnumerable<SystemUser> queuemembership_association
    {
        get => GetRelatedEntities<SystemUser>("queuemembership_association", null);
        set => SetRelatedEntities("queuemembership_association", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the Queue entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<Queue, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the Queue with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of Queue to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved Queue</returns>
    public static Queue Retrieve(IOrganizationService service, Guid id, params Expression<Func<Queue, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }
}
