using System.Runtime.Serialization;

namespace XrmBedrock.SharedContext;

[System.CodeDom.Compiler.GeneratedCode("DataverseProxyGenerator", "4.0.0.0")]
[DataContract]
#pragma warning disable CS8981
public enum environmentvariabledefinition_secretstore
#pragma warning restore CS8981
{
    [EnumMember]
    [OptionSetMetadata("Azure Key Vault", 1033)]
    AzureKeyVault = 0,

    [EnumMember]
    [OptionSetMetadata("Microsoft Dataverse", 1033)]
    MicrosoftDataverse = 1,
}
