using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum task_statuscode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Not Started", 1033)]
    NotStarted = 2,

    [EnumMember]
    [OptionSetMetadata("In Progress", 1033)]
    InProgress = 3,

    [EnumMember]
    [OptionSetMetadata("Waiting on someone else", 1033)]
    Waitingonsomeoneelse = 4,

    [EnumMember]
    [OptionSetMetadata("Completed", 1033)]
    Completed = 5,

    [EnumMember]
    [OptionSetMetadata("Canceled", 1033)]
    Canceled = 6,

    [EnumMember]
    [OptionSetMetadata("Deferred", 1033)]
    Deferred = 7,
}
