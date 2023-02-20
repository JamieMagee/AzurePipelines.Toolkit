namespace AzurePipelines.Toolkit.Variables;

public interface IPredefinedVariables
{
    /// <summary>
    /// </summary>
    IAgentVariables Agent { get; }

    /// <summary>
    /// </summary>
    IBuildVariables Build { get; }

    /// <summary>
    /// </summary>
    IChecksVariables Checks { get; }

    /// <summary>
    /// </summary>
    IDeploymentVariables Deployment { get; }

    /// <summary>
    /// </summary>
    IPipelineVariables Pipeline { get; }

    /// <summary>
    /// </summary>
    ISystemVariables System { get; }
}