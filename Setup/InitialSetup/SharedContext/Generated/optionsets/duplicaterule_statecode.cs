using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum duplicaterule_statecode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Inactive", 1033)]
    Inactive = 0,

    [EnumMember]
    [OptionSetMetadata("Active", 1033)]
    Active = 1,
}
