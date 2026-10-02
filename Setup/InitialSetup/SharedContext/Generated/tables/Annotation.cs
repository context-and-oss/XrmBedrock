using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace XrmBedrock.SharedContext;

/// <summary>
/// <para>Note that is attached to one or more objects, including other notes.</para>
/// <para>Display Name: Note</para>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[EntityLogicalName("annotation")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract]
#pragma warning disable CS8981 // Allows: Only lowercase characters
public partial class Annotation : ExtendedEntity
#pragma warning restore CS8981
{
    public const string EntityLogicalName = "annotation";
    public const int EntityTypeCode = 5;

    public Annotation() : base(EntityLogicalName) { }
    public Annotation(Guid id) : base(EntityLogicalName, id) { }

    private string DebuggerDisplay => GetDebuggerDisplay("subject");

    [AttributeLogicalName("annotationid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("annotationid", value);
        }
    }

    /// <summary>
    /// <para>Display Name: Note</para>
    /// </summary>
    [AttributeLogicalName("annotationid")]
    [DisplayName("Note")]
    public Guid? AnnotationId
    {
        get => GetAttributeValue<Guid?>("annotationid");
        set => SetId("annotationid", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who created the note.</para>
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
    /// <para>Date and time when the note was created.</para>
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
    /// <para>Unique identifier of the delegate user who created the annotation.</para>
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
    /// <para>Contents of the note's attachment.</para>
    /// <para>Display Name: Document</para>
    /// </summary>
    [AttributeLogicalName("documentbody")]
    [DisplayName("Document")]
    [MaxLength(1073741823)]
    public string? DocumentBody
    {
        get => GetAttributeValue<string?>("documentbody");
        set => SetAttributeValue("documentbody", value);
    }

    /// <summary>
    /// <para>Dummy attribute associated with the note attachment</para>
    /// <para>Display Name: File Name(deprecated)</para>
    /// </summary>
    [AttributeLogicalName("dummyfilename")]
    [DisplayName("File Name(deprecated)")]
    [MaxLength(500)]
    public string? DummyFileName
    {
        get => GetAttributeValue<string?>("dummyfilename");
        set => SetAttributeValue("dummyfilename", value);
    }

    /// <summary>
    /// <para>Dummy attribute associated with the note regarding</para>
    /// <para>Display Name: Regarding(deprecated)</para>
    /// </summary>
    [AttributeLogicalName("dummyregarding")]
    [DisplayName("Regarding(deprecated)")]
    [MaxLength(500)]
    public string? DummyRegarding
    {
        get => GetAttributeValue<string?>("dummyregarding");
        set => SetAttributeValue("dummyregarding", value);
    }

    /// <summary>
    /// <para>File name of the note.</para>
    /// <para>Display Name: File Name</para>
    /// </summary>
    [AttributeLogicalName("filename")]
    [DisplayName("File Name")]
    [MaxLength(255)]
    public string? FileName
    {
        get => GetAttributeValue<string?>("filename");
        set => SetAttributeValue("filename", value);
    }

    /// <summary>
    /// <para>File pointer of the attachment.</para>
    /// <para>Display Name: File Pointer</para>
    /// </summary>
    [AttributeLogicalName("filepointer")]
    [DisplayName("File Pointer")]
    [MaxLength(255)]
    public string? FilePointer
    {
        get => GetAttributeValue<string?>("filepointer");
        set => SetAttributeValue("filepointer", value);
    }

    /// <summary>
    /// <para>File size of the note.</para>
    /// <para>Display Name: File Size (Bytes)</para>
    /// </summary>
    [AttributeLogicalName("filesize")]
    [DisplayName("File Size (Bytes)")]
    [Range(0, 1000000000)]
    public int? FileSize
    {
        get => GetAttributeValue<int?>("filesize");
        set => SetAttributeValue("filesize", value);
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
    /// <para>Indicates if file is compressed in the storage.</para>
    /// <para>Display Name: Is Compressed</para>
    /// </summary>
    [AttributeLogicalName("iscompressed")]
    [DisplayName("Is Compressed")]
    public bool? IsCompressed
    {
        get => GetAttributeValue<bool?>("iscompressed");
        set => SetAttributeValue("iscompressed", value);
    }

    /// <summary>
    /// <para>Specifies whether the note is an attachment.</para>
    /// <para>Display Name: Is Document</para>
    /// </summary>
    [AttributeLogicalName("isdocument")]
    [DisplayName("Is Document")]
    public bool? IsDocument
    {
        get => GetAttributeValue<bool?>("isdocument");
        set => SetAttributeValue("isdocument", value);
    }

    /// <summary>
    /// <para>Display Name: isprivate</para>
    /// </summary>
    [AttributeLogicalName("isprivate")]
    [DisplayName("isprivate")]
    public bool? IsPrivate
    {
        get => GetAttributeValue<bool?>("isprivate");
        set => SetAttributeValue("isprivate", value);
    }

    /// <summary>
    /// <para>Language identifier for the note.</para>
    /// <para>Display Name: Language ID</para>
    /// </summary>
    [AttributeLogicalName("langid")]
    [DisplayName("Language ID")]
    [MaxLength(2)]
    public string? LangId
    {
        get => GetAttributeValue<string?>("langid");
        set => SetAttributeValue("langid", value);
    }

    /// <summary>
    /// <para>MIME type of the note's attachment.</para>
    /// <para>Display Name: Mime Type</para>
    /// </summary>
    [AttributeLogicalName("mimetype")]
    [DisplayName("Mime Type")]
    [MaxLength(256)]
    public string? MimeType
    {
        get => GetAttributeValue<string?>("mimetype");
        set => SetAttributeValue("mimetype", value);
    }

    /// <summary>
    /// <para>Unique identifier of the user who last modified the note.</para>
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
    /// <para>Date and time when the note was last modified.</para>
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
    /// <para>Unique identifier of the delegate user who last modified the annotation.</para>
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
    /// <para>Text of the note.</para>
    /// <para>Display Name: Description</para>
    /// </summary>
    [AttributeLogicalName("notetext")]
    [DisplayName("Description")]
    [MaxLength(100000)]
    public string? NoteText
    {
        get => GetAttributeValue<string?>("notetext");
        set => SetAttributeValue("notetext", value);
    }

    /// <summary>
    /// <para>Unique identifier of the object with which the note is associated.</para>
    /// <para>Display Name: Regarding</para>
    /// </summary>
    [AttributeLogicalName("objectid")]
    [DisplayName("Regarding")]
    public EntityReference? ObjectId
    {
        get => GetAttributeValue<EntityReference?>("objectid");
        set => SetAttributeValue("objectid", value);
    }

    /// <summary>
    /// <para>Type of entity with which the note is associated.</para>
    /// <para>Display Name: Object Type </para>
    /// </summary>
    [AttributeLogicalName("objecttypecode")]
    [DisplayName("Object Type ")]
    [MaxLength()]
    public string? ObjectTypeCode
    {
        get => GetAttributeValue<string?>("objecttypecode");
        set => SetAttributeValue("objecttypecode", value);
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
    /// <para>Unique identifier of the user or team who owns the note.</para>
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
    /// <para>Unique identifier of the business unit that owns the note.</para>
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
    /// <para>Unique identifier of the team who owns the note.</para>
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
    /// <para>Unique identifier of the user who owns the note.</para>
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
    /// <para>Prefix of the file pointer in blob storage.</para>
    /// <para>Display Name: Prefix</para>
    /// </summary>
    [AttributeLogicalName("prefix")]
    [DisplayName("Prefix")]
    [MaxLength(10)]
    public string? Prefix
    {
        get => GetAttributeValue<string?>("prefix");
        set => SetAttributeValue("prefix", value);
    }

    /// <summary>
    /// <para>workflow step id associated with the note.</para>
    /// <para>Display Name: Step Id</para>
    /// </summary>
    [AttributeLogicalName("stepid")]
    [DisplayName("Step Id")]
    [MaxLength(32)]
    public string? StepId
    {
        get => GetAttributeValue<string?>("stepid");
        set => SetAttributeValue("stepid", value);
    }

    /// <summary>
    /// <para>Storage pointer.</para>
    /// <para>Display Name: Storage Pointer</para>
    /// </summary>
    [AttributeLogicalName("storagepointer")]
    [DisplayName("Storage Pointer")]
    [MaxLength(10)]
    public string? StoragePointer
    {
        get => GetAttributeValue<string?>("storagepointer");
        set => SetAttributeValue("storagepointer", value);
    }

    /// <summary>
    /// <para>Subject associated with the note.</para>
    /// <para>Display Name: Title</para>
    /// </summary>
    [AttributeLogicalName("subject")]
    [DisplayName("Title")]
    [MaxLength(500)]
    public string? Subject
    {
        get => GetAttributeValue<string?>("subject");
        set => SetAttributeValue("subject", value);
    }

    /// <summary>
    /// <para>Version number of the note.</para>
    /// <para>Display Name: Version Number</para>
    /// </summary>
    [AttributeLogicalName("versionnumber")]
    [DisplayName("Version Number")]
    public long? VersionNumber
    {
        get => GetAttributeValue<long?>("versionnumber");
        set => SetAttributeValue("versionnumber", value);
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Account_Annotation")]
    [RelationshipMetadata("ManyToOne", "objectid", "account", "accountid", "Referencing")]
    public Account Account_Annotation
    {
        get => GetRelatedEntity<Account>("Account_Annotation", null);
        set => SetRelatedEntity("Account_Annotation", null, value);
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("annotation_owning_user")]
    [RelationshipMetadata("ManyToOne", "owninguser", "systemuser", "systemuserid", "Referencing")]
    public SystemUser annotation_owning_user
    {
        get => GetRelatedEntity<SystemUser>("annotation_owning_user", null);
        set => SetRelatedEntity("annotation_owning_user", null, value);
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Contact_Annotation")]
    [RelationshipMetadata("ManyToOne", "objectid", "contact", "contactid", "Referencing")]
    public Contact Contact_Annotation
    {
        get => GetRelatedEntity<Contact>("Contact_Annotation", null);
        set => SetRelatedEntity("Contact_Annotation", null, value);
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("DuplicateRule_Annotation")]
    [RelationshipMetadata("ManyToOne", "objectid", "duplicaterule", "duplicateruleid", "Referencing")]
    public DuplicateRule DuplicateRule_Annotation
    {
        get => GetRelatedEntity<DuplicateRule>("DuplicateRule_Annotation", null);
        set => SetRelatedEntity("DuplicateRule_Annotation", null, value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_annotationbase_createdby")]
    [RelationshipMetadata("ManyToOne", "createdby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_annotationbase_createdby
    {
        get => GetRelatedEntity<SystemUser>("lk_annotationbase_createdby", null);
        set => SetRelatedEntity("lk_annotationbase_createdby", null, value);
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_annotationbase_createdonbehalfby")]
    [RelationshipMetadata("ManyToOne", "createdonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_annotationbase_createdonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_annotationbase_createdonbehalfby", null);
        set => SetRelatedEntity("lk_annotationbase_createdonbehalfby", null, value);
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_annotationbase_modifiedby")]
    [RelationshipMetadata("ManyToOne", "modifiedby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_annotationbase_modifiedby
    {
        get => GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedby", null);
        set => SetRelatedEntity("lk_annotationbase_modifiedby", null, value);
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_annotationbase_modifiedonbehalfby")]
    [RelationshipMetadata("ManyToOne", "modifiedonbehalfby", "systemuser", "systemuserid", "Referencing")]
    public SystemUser lk_annotationbase_modifiedonbehalfby
    {
        get => GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedonbehalfby", null);
        set => SetRelatedEntity("lk_annotationbase_modifiedonbehalfby", null, value);
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Task_Annotation")]
    [RelationshipMetadata("ManyToOne", "objectid", "task", "activityid", "Referencing")]
    public Task Task_Annotation
    {
        get => GetRelatedEntity<Task>("Task_Annotation", null);
        set => SetRelatedEntity("Task_Annotation", null, value);
    }

    /// <summary>
    /// Gets the logical column name for a property on the Annotation entity, using the AttributeLogicalNameAttribute if present.
    /// </summary>
    /// <param name="column">Expression to pick the column</param>
    /// <returns>Name of column</returns>
    /// <exception cref="ArgumentNullException">If no expression is provided</exception>
    /// <exception cref="ArgumentException">If the expression is not x => x.column</exception>
    public static string GetColumnName(Expression<Func<Annotation, object?>> column)
    {
        return TableAttributeHelpers.GetColumnName(column);
    }

    /// <summary>
    /// Retrieves the Annotation with the specified columns.
    /// </summary>
    /// <param name="service">Organization service</param>
    /// <param name="id">Id of Annotation to retrieve</param>
    /// <param name="columns">Expressions that specify columns to retrieve</param>
    /// <returns>The retrieved Annotation</returns>
    public static Annotation Retrieve(IOrganizationService service, Guid id, params Expression<Func<Annotation, object?>>[] columns)
    {
        return service.Retrieve(id, columns);
    }
}
