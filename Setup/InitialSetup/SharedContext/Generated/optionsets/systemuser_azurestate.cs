using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum systemuser_azurestate
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Exists", 1033)]
    Exists = 0,

    [EnumMember]
    [OptionSetMetadata("Soft deleted", 1033)]
    Softdeleted = 1,

    [EnumMember]
    [OptionSetMetadata("Not found or hard deleted", 1033)]
    Notfoundorharddeleted = 2,
}
