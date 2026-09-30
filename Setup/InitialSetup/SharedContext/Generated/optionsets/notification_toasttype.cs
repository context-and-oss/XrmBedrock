using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum notification_toasttype
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Timed", 1033)]
    Timed = 200000000,

    [EnumMember]
    [OptionSetMetadata("Hidden", 1033)]
    Hidden = 200000001,
}
