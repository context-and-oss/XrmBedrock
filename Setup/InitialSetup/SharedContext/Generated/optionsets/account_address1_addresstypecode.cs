using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum account_address1_addresstypecode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Bill To", 1033)]
    BillTo = 1,

    [EnumMember]
    [OptionSetMetadata("Ship To", 1033)]
    ShipTo = 2,

    [EnumMember]
    [OptionSetMetadata("Primary", 1033)]
    Primary = 3,

    [EnumMember]
    [OptionSetMetadata("Other", 1033)]
    Other = 4,
}
