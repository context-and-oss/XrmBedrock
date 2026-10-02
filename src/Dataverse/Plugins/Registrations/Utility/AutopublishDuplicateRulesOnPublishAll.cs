using DataverseLogic.Utility;
using Microsoft.Xrm.Sdk;
using XrmPluginCore.Enums;

namespace DataverseRegistration.Utility;

/// <summary>
/// This plugin is responsible for autopublishing duplicate detection rules on PublishAll.
/// It will only publish unpublished rules that have a description containing "AutoPublish".
/// It solves the problem of duplicate detection rules being unpublished after a solution import.
/// </summary>
public class AutopublishDuplicateRulesOnPublishAll : Plugin
{
    public AutopublishDuplicateRulesOnPublishAll()
    {
        RegisterStep<Entity, DuplicateRuleService>(
            EventOperation.PublishAll,
            ExecutionStage.PostOperation,
            service => service.AutopublishRules())
            .SetExecutionMode(ExecutionMode.Asynchronous);
    }
}
