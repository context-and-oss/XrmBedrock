using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum task_statecode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Open", 1033)]
    Open = 0,

    [EnumMember]
    [OptionSetMetadata("Completed", 1033)]
    Completed = 1,

    [EnumMember]
    [OptionSetMetadata("Canceled", 1033)]
    Canceled = 2,
}
