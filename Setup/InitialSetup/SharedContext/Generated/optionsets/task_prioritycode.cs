using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum task_prioritycode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Low", 1033)]
    Low = 0,

    [EnumMember]
    [OptionSetMetadata("Normal", 1033)]
    Normal = 1,

    [EnumMember]
    [OptionSetMetadata("High", 1033)]
    High = 2,
}
