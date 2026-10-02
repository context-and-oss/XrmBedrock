using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum queue_incomingemailfilteringmethod
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("All email messages", 1033)]
    Allemailmessages = 0,

    [EnumMember]
    [OptionSetMetadata("Email messages in response to Dynamics 365 email", 1033)]
    EmailmessagesinresponsetoDynamics365email = 1,

    [EnumMember]
    [OptionSetMetadata("Email messages from Dynamics 365 Leads, Contacts and Accounts", 1033)]
    EmailmessagesfromDynamics365LeadsContactsandAccounts = 2,

    [EnumMember]
    [OptionSetMetadata("Email messages from Dynamics 365 records that are email enabled", 1033)]
    EmailmessagesfromDynamics365recordsthatareemailenabled = 3,

    [EnumMember]
    [OptionSetMetadata("No email messages", 1033)]
    Noemailmessages = 4,
}
