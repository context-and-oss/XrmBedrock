using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum contact_accountrolecode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Decision Maker", 1033)]
    DecisionMaker = 1,

    [EnumMember]
    [OptionSetMetadata("Employee", 1033)]
    Employee = 2,

    [EnumMember]
    [OptionSetMetadata("Influencer", 1033)]
    Influencer = 3,
}
