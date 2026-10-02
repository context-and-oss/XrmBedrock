using Microsoft.Xrm.Sdk;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
public interface ICustomer
{
    /// <summary>
    /// <para>Unique identifier for address 1.</para>
    /// <para>Display Name: Address 1: ID</para>
    /// </summary>
    Guid? Address1_AddressId { get; set; }

    /// <summary>
    /// <para>Type the city for the primary address.</para>
    /// <para>Display Name: Address 1: City</para>
    /// </summary>
    string? Address1_City { get; set; }

    /// <summary>
    /// <para>Shows the complete primary address.</para>
    /// <para>Display Name: Address 1</para>
    /// </summary>
    string? Address1_Composite { get; set; }

    /// <summary>
    /// <para>Type the country or region for the primary address.</para>
    /// <para>Display Name: Address 1: Country/Region</para>
    /// </summary>
    string? Address1_Country { get; set; }

    /// <summary>
    /// <para>Type the county for the primary address.</para>
    /// <para>Display Name: Address 1: County</para>
    /// </summary>
    string? Address1_County { get; set; }

    /// <summary>
    /// <para>Type the fax number associated with the primary address.</para>
    /// <para>Display Name: Address 1: Fax</para>
    /// </summary>
    string? Address1_Fax { get; set; }

    /// <summary>
    /// <para>Type the latitude value for the primary address for use in mapping and other applications.</para>
    /// <para>Display Name: Address 1: Latitude</para>
    /// </summary>
    double? Address1_Latitude { get; set; }

    /// <summary>
    /// <para>Type the first line of the primary address.</para>
    /// <para>Display Name: Address 1: Street 1</para>
    /// </summary>
    string? Address1_Line1 { get; set; }

    /// <summary>
    /// <para>Type the second line of the primary address.</para>
    /// <para>Display Name: Address 1: Street 2</para>
    /// </summary>
    string? Address1_Line2 { get; set; }

    /// <summary>
    /// <para>Type the third line of the primary address.</para>
    /// <para>Display Name: Address 1: Street 3</para>
    /// </summary>
    string? Address1_Line3 { get; set; }

    /// <summary>
    /// <para>Type the longitude value for the primary address for use in mapping and other applications.</para>
    /// <para>Display Name: Address 1: Longitude</para>
    /// </summary>
    double? Address1_Longitude { get; set; }

    /// <summary>
    /// <para>Type a descriptive name for the primary address, such as Corporate Headquarters.</para>
    /// <para>Display Name: Address 1: Name</para>
    /// </summary>
    string? Address1_Name { get; set; }

    /// <summary>
    /// <para>Type the ZIP Code or postal code for the primary address.</para>
    /// <para>Display Name: Address 1: ZIP/Postal Code</para>
    /// </summary>
    string? Address1_PostalCode { get; set; }

    /// <summary>
    /// <para>Type the post office box number of the primary address.</para>
    /// <para>Display Name: Address 1: Post Office Box</para>
    /// </summary>
    string? Address1_PostOfficeBox { get; set; }

    /// <summary>
    /// <para>Type the name of the main contact at the account's primary address.</para>
    /// <para>Display Name: Address 1: Primary Contact Name</para>
    /// </summary>
    string? Address1_PrimaryContactName { get; set; }

    /// <summary>
    /// <para>Type the state or province of the primary address.</para>
    /// <para>Display Name: Address 1: State/Province</para>
    /// </summary>
    string? Address1_StateOrProvince { get; set; }

    /// <summary>
    /// <para>Type the main phone number associated with the primary address.</para>
    /// <para>Display Name: Address Phone</para>
    /// </summary>
    string? Address1_Telephone1 { get; set; }

    /// <summary>
    /// <para>Type a second phone number associated with the primary address.</para>
    /// <para>Display Name: Address 1: Telephone 2</para>
    /// </summary>
    string? Address1_Telephone2 { get; set; }

    /// <summary>
    /// <para>Type a third phone number associated with the primary address.</para>
    /// <para>Display Name: Address 1: Telephone 3</para>
    /// </summary>
    string? Address1_Telephone3 { get; set; }

    /// <summary>
    /// <para>Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</para>
    /// <para>Display Name: Address 1: UPS Zone</para>
    /// </summary>
    string? Address1_UPSZone { get; set; }

    /// <summary>
    /// <para>Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</para>
    /// <para>Display Name: Address 1: UTC Offset</para>
    /// </summary>
    int? Address1_UTCOffset { get; set; }

    /// <summary>
    /// <para>Unique identifier for address 2.</para>
    /// <para>Display Name: Address 2: ID</para>
    /// </summary>
    Guid? Address2_AddressId { get; set; }

    /// <summary>
    /// <para>Type the city for the secondary address.</para>
    /// <para>Display Name: Address 2: City</para>
    /// </summary>
    string? Address2_City { get; set; }

    /// <summary>
    /// <para>Shows the complete secondary address.</para>
    /// <para>Display Name: Address 2</para>
    /// </summary>
    string? Address2_Composite { get; set; }

    /// <summary>
    /// <para>Type the country or region for the secondary address.</para>
    /// <para>Display Name: Address 2: Country/Region</para>
    /// </summary>
    string? Address2_Country { get; set; }

    /// <summary>
    /// <para>Type the county for the secondary address.</para>
    /// <para>Display Name: Address 2: County</para>
    /// </summary>
    string? Address2_County { get; set; }

    /// <summary>
    /// <para>Type the fax number associated with the secondary address.</para>
    /// <para>Display Name: Address 2: Fax</para>
    /// </summary>
    string? Address2_Fax { get; set; }

    /// <summary>
    /// <para>Type the latitude value for the secondary address for use in mapping and other applications.</para>
    /// <para>Display Name: Address 2: Latitude</para>
    /// </summary>
    double? Address2_Latitude { get; set; }

    /// <summary>
    /// <para>Type the first line of the secondary address.</para>
    /// <para>Display Name: Address 2: Street 1</para>
    /// </summary>
    string? Address2_Line1 { get; set; }

    /// <summary>
    /// <para>Type the second line of the secondary address.</para>
    /// <para>Display Name: Address 2: Street 2</para>
    /// </summary>
    string? Address2_Line2 { get; set; }

    /// <summary>
    /// <para>Type the third line of the secondary address.</para>
    /// <para>Display Name: Address 2: Street 3</para>
    /// </summary>
    string? Address2_Line3 { get; set; }

    /// <summary>
    /// <para>Type the longitude value for the secondary address for use in mapping and other applications.</para>
    /// <para>Display Name: Address 2: Longitude</para>
    /// </summary>
    double? Address2_Longitude { get; set; }

    /// <summary>
    /// <para>Type a descriptive name for the secondary address, such as Corporate Headquarters.</para>
    /// <para>Display Name: Address 2: Name</para>
    /// </summary>
    string? Address2_Name { get; set; }

    /// <summary>
    /// <para>Type the ZIP Code or postal code for the secondary address.</para>
    /// <para>Display Name: Address 2: ZIP/Postal Code</para>
    /// </summary>
    string? Address2_PostalCode { get; set; }

    /// <summary>
    /// <para>Type the post office box number of the secondary address.</para>
    /// <para>Display Name: Address 2: Post Office Box</para>
    /// </summary>
    string? Address2_PostOfficeBox { get; set; }

    /// <summary>
    /// <para>Type the name of the main contact at the account's secondary address.</para>
    /// <para>Display Name: Address 2: Primary Contact Name</para>
    /// </summary>
    string? Address2_PrimaryContactName { get; set; }

    /// <summary>
    /// <para>Type the state or province of the secondary address.</para>
    /// <para>Display Name: Address 2: State/Province</para>
    /// </summary>
    string? Address2_StateOrProvince { get; set; }

    /// <summary>
    /// <para>Type the main phone number associated with the secondary address.</para>
    /// <para>Display Name: Address 2: Telephone 1</para>
    /// </summary>
    string? Address2_Telephone1 { get; set; }

    /// <summary>
    /// <para>Type a second phone number associated with the secondary address.</para>
    /// <para>Display Name: Address 2: Telephone 2</para>
    /// </summary>
    string? Address2_Telephone2 { get; set; }

    /// <summary>
    /// <para>Type a third phone number associated with the secondary address.</para>
    /// <para>Display Name: Address 2: Telephone 3</para>
    /// </summary>
    string? Address2_Telephone3 { get; set; }

    /// <summary>
    /// <para>Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.</para>
    /// <para>Display Name: Address 2: UPS Zone</para>
    /// </summary>
    string? Address2_UPSZone { get; set; }

    /// <summary>
    /// <para>Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.</para>
    /// <para>Display Name: Address 2: UTC Offset</para>
    /// </summary>
    int? Address2_UTCOffset { get; set; }

    /// <summary>
    /// <para>Display Name: Created By (IP Address)</para>
    /// </summary>
    string? Adx_CreatedByIPAddress { get; set; }

    /// <summary>
    /// <para>Display Name: Created By (User Name)</para>
    /// </summary>
    string? Adx_CreatedByUsername { get; set; }

    /// <summary>
    /// <para>Display Name: Modified By (IP Address)</para>
    /// </summary>
    string? Adx_ModifiedByIPAddress { get; set; }

    /// <summary>
    /// <para>Display Name: Modified By (User Name)</para>
    /// </summary>
    string? Adx_ModifiedByUsername { get; set; }

    /// <summary>
    /// <para>For system use only.</para>
    /// <para>Display Name: Aging 30</para>
    /// </summary>
    decimal? Aging30 { get; set; }

    /// <summary>
    /// <para>The base currency equivalent of the aging 30 field.</para>
    /// <para>Display Name: Aging 30 (Base)</para>
    /// </summary>
    decimal? Aging30_Base { get; set; }

    /// <summary>
    /// <para>For system use only.</para>
    /// <para>Display Name: Aging 60</para>
    /// </summary>
    decimal? Aging60 { get; set; }

    /// <summary>
    /// <para>The base currency equivalent of the aging 60 field.</para>
    /// <para>Display Name: Aging 60 (Base)</para>
    /// </summary>
    decimal? Aging60_Base { get; set; }

    /// <summary>
    /// <para>For system use only.</para>
    /// <para>Display Name: Aging 90</para>
    /// </summary>
    decimal? Aging90 { get; set; }

    /// <summary>
    /// <para>The base currency equivalent of the aging 90 field.</para>
    /// <para>Display Name: Aging 90 (Base)</para>
    /// </summary>
    decimal? Aging90_Base { get; set; }

    /// <summary>
    /// <para>Shows who created the record.</para>
    /// <para>Display Name: Created By</para>
    /// </summary>
    EntityReference? CreatedBy { get; set; }

    /// <summary>
    /// <para>Shows the external party who created the record.</para>
    /// <para>Display Name: Created By (External Party)</para>
    /// </summary>
    EntityReference? CreatedByExternalParty { get; set; }

    /// <summary>
    /// <para>Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</para>
    /// <para>Display Name: Created On</para>
    /// </summary>
    DateTime? CreatedOn { get; set; }

    /// <summary>
    /// <para>Shows who created the record on behalf of another user.</para>
    /// <para>Display Name: Created By (Delegate)</para>
    /// </summary>
    EntityReference? CreatedOnBehalfBy { get; set; }

    /// <summary>
    /// <para>Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.</para>
    /// <para>Display Name: Credit Limit</para>
    /// </summary>
    decimal? CreditLimit { get; set; }

    /// <summary>
    /// <para>Shows the credit limit converted to the system's default base currency for reporting purposes.</para>
    /// <para>Display Name: Credit Limit (Base)</para>
    /// </summary>
    decimal? CreditLimit_Base { get; set; }

    /// <summary>
    /// <para>Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.</para>
    /// <para>Display Name: Credit Hold</para>
    /// </summary>
    bool? CreditOnHold { get; set; }

    /// <summary>
    /// <para>Type additional information to describe the account, such as an excerpt from the company's website.</para>
    /// <para>Display Name: Description</para>
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// <para>Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.</para>
    /// <para>Display Name: Do not allow Bulk Emails</para>
    /// </summary>
    bool? DoNotBulkEMail { get; set; }

    /// <summary>
    /// <para>Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.</para>
    /// <para>Display Name: Do not allow Bulk Mails</para>
    /// </summary>
    bool? DoNotBulkPostalMail { get; set; }

    /// <summary>
    /// <para>Select whether the account allows direct email sent from Microsoft Dynamics 365.</para>
    /// <para>Display Name: Do not allow Emails</para>
    /// </summary>
    bool? DoNotEMail { get; set; }

    /// <summary>
    /// <para>Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.</para>
    /// <para>Display Name: Do not allow Faxes</para>
    /// </summary>
    bool? DoNotFax { get; set; }

    /// <summary>
    /// <para>Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.</para>
    /// <para>Display Name: Do not allow Phone Calls</para>
    /// </summary>
    bool? DoNotPhone { get; set; }

    /// <summary>
    /// <para>Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.</para>
    /// <para>Display Name: Do not allow Mails</para>
    /// </summary>
    bool? DoNotPostalMail { get; set; }

    /// <summary>
    /// <para>Select whether the account accepts marketing materials, such as brochures or catalogs.</para>
    /// <para>Display Name: Send Marketing Materials</para>
    /// </summary>
    bool? DoNotSendMM { get; set; }

    /// <summary>
    /// <para>Type the primary email address for the account.</para>
    /// <para>Display Name: Email</para>
    /// </summary>
    string? EMailAddress1 { get; set; }

    /// <summary>
    /// <para>Type the secondary email address for the account.</para>
    /// <para>Display Name: Email Address 2</para>
    /// </summary>
    string? EMailAddress2 { get; set; }

    /// <summary>
    /// <para>Type an alternate email address for the account.</para>
    /// <para>Display Name: Email Address 3</para>
    /// </summary>
    string? EMailAddress3 { get; set; }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Entity Image Id</para>
    /// </summary>
    Guid? EntityImageId { get; set; }

    /// <summary>
    /// <para>Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.</para>
    /// <para>Display Name: Exchange Rate</para>
    /// </summary>
    decimal? ExchangeRate { get; set; }

    /// <summary>
    /// <para>Type the fax number for the account.</para>
    /// <para>Display Name: Fax</para>
    /// </summary>
    string? Fax { get; set; }

    /// <summary>
    /// <para>Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.</para>
    /// <para>Display Name: Follow Email Activity</para>
    /// </summary>
    bool? FollowEmail { get; set; }

    /// <summary>
    /// <para>Unique identifier of the data import or data migration that created this record.</para>
    /// <para>Display Name: Import Sequence Number</para>
    /// </summary>
    int? ImportSequenceNumber { get; set; }

    /// <summary>
    /// <para>Display Name: isprivate</para>
    /// </summary>
    bool? IsPrivate { get; set; }

    /// <summary>
    /// <para>Contains the date and time stamp of the last on hold time.</para>
    /// <para>Display Name: Last On Hold Time</para>
    /// </summary>
    DateTime? LastOnHoldTime { get; set; }

    /// <summary>
    /// <para>Shows the date when the account was last included in a marketing campaign or quick campaign.</para>
    /// <para>Display Name: Last Date Included in Campaign</para>
    /// </summary>
    DateTime? LastUsedInCampaign { get; set; }

    /// <summary>
    /// <para>Whether is only for marketing</para>
    /// <para>Display Name: Marketing Only</para>
    /// </summary>
    bool? MarketingOnly { get; set; }

    /// <summary>
    /// <para>Shows the master account that the account was merged with.</para>
    /// <para>Display Name: Master ID</para>
    /// </summary>
    EntityReference? MasterId { get; set; }

    /// <summary>
    /// <para>Shows whether the account has been merged with another account.</para>
    /// <para>Display Name: Merged</para>
    /// </summary>
    bool? Merged { get; set; }

    /// <summary>
    /// <para>Shows who last updated the record.</para>
    /// <para>Display Name: Modified By</para>
    /// </summary>
    EntityReference? ModifiedBy { get; set; }

    /// <summary>
    /// <para>Shows the external party who modified the record.</para>
    /// <para>Display Name: Modified By (External Party)</para>
    /// </summary>
    EntityReference? ModifiedByExternalParty { get; set; }

    /// <summary>
    /// <para>Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</para>
    /// <para>Display Name: Modified On</para>
    /// </summary>
    DateTime? ModifiedOn { get; set; }

    /// <summary>
    /// <para>Shows who created the record on behalf of another user.</para>
    /// <para>Display Name: Modified By (Delegate)</para>
    /// </summary>
    EntityReference? ModifiedOnBehalfBy { get; set; }

    /// <summary>
    /// <para>Unique identifier for Account associated with Account.</para>
    /// <para>Display Name: Managing Partner</para>
    /// </summary>
    EntityReference? msa_managingpartnerid { get; set; }

    /// <summary>
    /// <para>Shows how long, in minutes, that the record was on hold.</para>
    /// <para>Display Name: On Hold Time (Minutes)</para>
    /// </summary>
    int? OnHoldTime { get; set; }

    /// <summary>
    /// <para>Date and time that the record was migrated.</para>
    /// <para>Display Name: Record Created On</para>
    /// </summary>
    DateTime? OverriddenCreatedOn { get; set; }

    /// <summary>
    /// <para>Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</para>
    /// <para>Display Name: Owner</para>
    /// </summary>
    EntityReference? OwnerId { get; set; }

    /// <summary>
    /// <para>Shows the business unit that the record owner belongs to.</para>
    /// <para>Display Name: Owning Business Unit</para>
    /// </summary>
    EntityReference? OwningBusinessUnit { get; set; }

    /// <summary>
    /// <para>Unique identifier of the team who owns the account.</para>
    /// <para>Display Name: Owning Team</para>
    /// </summary>
    EntityReference? OwningTeam { get; set; }

    /// <summary>
    /// <para>Unique identifier of the user who owns the account.</para>
    /// <para>Display Name: Owning User</para>
    /// </summary>
    EntityReference? OwningUser { get; set; }

    /// <summary>
    /// <para>For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.</para>
    /// <para>Display Name: Participates in Workflow</para>
    /// </summary>
    bool? ParticipatesInWorkflow { get; set; }

    /// <summary>
    /// <para>Choose the preferred service representative for reference when you schedule service activities for the account.</para>
    /// <para>Display Name: Preferred User</para>
    /// </summary>
    EntityReference? PreferredSystemUserId { get; set; }

    /// <summary>
    /// <para>Shows the ID of the process.</para>
    /// <para>Display Name: Process</para>
    /// </summary>
    Guid? ProcessId { get; set; }

    /// <summary>
    /// <para>Choose the service level agreement (SLA) that you want to apply to the Account record.</para>
    /// <para>Display Name: SLA</para>
    /// </summary>
    EntityReference? SLAId { get; set; }

    /// <summary>
    /// <para>Last SLA that was applied to this case. This field is for internal use only.</para>
    /// <para>Display Name: Last SLA applied</para>
    /// </summary>
    EntityReference? SLAInvokedId { get; set; }

    /// <summary>
    /// <para>Shows the ID of the stage.</para>
    /// <para>Display Name: (Deprecated) Process Stage</para>
    /// </summary>
    Guid? StageId { get; set; }

    /// <summary>
    /// <para>Type the main phone number for this account.</para>
    /// <para>Display Name: Main Phone</para>
    /// </summary>
    string? Telephone1 { get; set; }

    /// <summary>
    /// <para>Type a second phone number for this account.</para>
    /// <para>Display Name: Other Phone</para>
    /// </summary>
    string? Telephone2 { get; set; }

    /// <summary>
    /// <para>Type a third phone number for this account.</para>
    /// <para>Display Name: Telephone 3</para>
    /// </summary>
    string? Telephone3 { get; set; }

    /// <summary>
    /// <para>Total time spent for emails (read and write) and meetings by me in relation to account record.</para>
    /// <para>Display Name: Time Spent by me</para>
    /// </summary>
    string? TimeSpentByMeOnEmailAndMeetings { get; set; }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Time Zone Rule Version Number</para>
    /// </summary>
    int? TimeZoneRuleVersionNumber { get; set; }

    /// <summary>
    /// <para>Choose the local currency for the record to make sure budgets are reported in the correct currency.</para>
    /// <para>Display Name: Currency</para>
    /// </summary>
    EntityReference? TransactionCurrencyId { get; set; }

    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: (Deprecated) Traversed Path</para>
    /// </summary>
    string? TraversedPath { get; set; }

    /// <summary>
    /// <para>Time zone code that was in use when the record was created.</para>
    /// <para>Display Name: UTC Conversion Time Zone Code</para>
    /// </summary>
    int? UTCConversionTimeZoneCode { get; set; }

    /// <summary>
    /// <para>Version number of the account.</para>
    /// <para>Display Name: Version Number</para>
    /// </summary>
    long? VersionNumber { get; set; }
}
