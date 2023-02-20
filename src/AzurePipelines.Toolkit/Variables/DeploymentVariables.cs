namespace AzurePipelines.Toolkit.Variables;

using AzurePipelines.Toolkit.Utilities;

/// <inheritdoc />
internal sealed class DeploymentVariables : IDeploymentVariables
{
    /// <inheritdoc />
    public string? EnvironmentName => EnvironmentInfo.GetVariable("ENVIRONMENT_NAME");

    /// <inheritdoc />
    public string? EnvironmentId => EnvironmentInfo.GetVariable("ENVIRONMENT_ID");

    /// <inheritdoc />
    public string? EnvironmentResourceName => EnvironmentInfo.GetVariable("ENVIRONMENT_RESOURCENAME");

    /// <inheritdoc />
    public string? EnvironmentResourceId => EnvironmentInfo.GetVariable("ENVIRONMENT_RESOURCEID");

    /// <inheritdoc />
    public string? StrategyName => EnvironmentInfo.GetVariable("STRATEGY_NAME");

    /// <inheritdoc />
    public string? StrategyCycleName => EnvironmentInfo.GetVariable("STRATEGY_CYCLENAME");
}