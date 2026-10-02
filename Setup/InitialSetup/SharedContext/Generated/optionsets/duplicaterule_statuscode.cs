using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum duplicaterule_statuscode
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Unpublished", 1033)]
    Unpublished = 0,

    [EnumMember]
    [OptionSetMetadata("Publishing", 1033)]
    Publishing = 1,

    [EnumMember]
    [OptionSetMetadata("Published", 1033)]
    Published = 2,
}
