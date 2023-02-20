namespace AzurePipelines.Toolkit;

using AzurePipelines.Toolkit.Commands;
using AzurePipelines.Toolkit.Variables;

/// <summary>
/// </summary>
public interface IAzurePipelinesToolkit
{
    /// <summary>
    /// </summary>
    IFormattingCommands Format { get; }

    /// <summary>
    /// </summary>
    ITaskCommands Task { get; }

    /// <summary>
    /// </summary>
    IArtifactCommands Artifact { get; }

    /// <summary>
    /// </summary>
    IBuildCommands Build { get; }

    /// <summary>
    /// </summary>
    IReleaseCommands Release { get; }

    /// <summary>
    /// </summary>
    IPredefinedVariables Variables { get; }
}