namespace AzurePipelines.Toolkit.Variables;

/// <summary>
///     Azure Pipelines predefined environment variables.
///     <a href="https://learn.microsoft.com/en-us/azure/devops/pipelines/build/variables">See more</a>.
/// </summary>
internal sealed class PredefinedVariables : IPredefinedVariables
{
    internal PredefinedVariables()
    {
        this.Agent = new AgentVariables();
        this.Build = new BuildVariables();
        this.Checks = new ChecksVariables();
        this.Deployment = new DeploymentVariables();
        this.Pipeline = new PipelineVariables();
        this.System = new SystemVariables();
    }

    /// <inheritdoc />
    public IAgentVariables Agent { get; }

    /// <inheritdoc />
    public IBuildVariables Build { get; }

    /// <inheritdoc />
    public IChecksVariables Checks { get; }

    /// <inheritdoc />
    public IDeploymentVariables Deployment { get; }

    /// <inheritdoc />
    public IPipelineVariables Pipeline { get; }

    /// <inheritdoc />
    public ISystemVariables System { get; }
}