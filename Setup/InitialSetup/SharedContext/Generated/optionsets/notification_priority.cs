using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum notification_priority
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Normal", 1033)]
    Normal = 200000000,

    [EnumMember]
    [OptionSetMetadata("High", 1033)]
    High = 200000001,
}
