namespace AzurePipelines.Toolkit.Variables;

using AzurePipelines.Toolkit.Utilities;

/// <inheritdoc />
internal sealed class PipelineVariables : IPipelineVariables
{
    /// <inheritdoc />
    public string? Workspace => EnvironmentInfo.GetVariable("PIPELINE_WORKSPACE");
}