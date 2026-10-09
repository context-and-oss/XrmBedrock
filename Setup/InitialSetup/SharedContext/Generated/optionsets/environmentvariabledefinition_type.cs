using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum environmentvariabledefinition_type
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("String", 1033)]
    @String = 100000000,

    [EnumMember]
    [OptionSetMetadata("Number", 1033)]
    Number = 100000001,

    [EnumMember]
    [OptionSetMetadata("Boolean", 1033)]
    Boolean = 100000002,

    [EnumMember]
    [OptionSetMetadata("JSON", 1033)]
    JSON = 100000003,

    [EnumMember]
    [OptionSetMetadata("Data Source", 1033)]
    DataSource = 100000004,

    [EnumMember]
    [OptionSetMetadata("Secret", 1033)]
    Secret = 100000005,
}
