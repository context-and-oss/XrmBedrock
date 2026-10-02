using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum notification_iconid
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Info", 1033)]
    Info = 100000000,

    [EnumMember]
    [OptionSetMetadata("Success", 1033)]
    Success = 100000001,

    [EnumMember]
    [OptionSetMetadata("Failure", 1033)]
    Failure = 100000002,

    [EnumMember]
    [OptionSetMetadata("Warning", 1033)]
    Warning = 100000003,

    [EnumMember]
    [OptionSetMetadata("Mention", 1033)]
    Mention = 100000004,

    [EnumMember]
    [OptionSetMetadata("Custom", 1033)]
    Custom = 100000005,
}
