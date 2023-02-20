namespace AzurePipelines.Toolkit.Variables;

public interface IBuildVariables
{
    /// <summary>
    /// </summary>
    string? BuildId { get; }

    /// <summary>
    /// </summary>
    string? BuildNumber { get; }

    /// <summary>
    /// </summary>
    string? BuildUri { get; }

    /// <summary>
    /// </summary>
    string? BinariesDirectory { get; }

    /// <summary>
    /// </summary>
    string? ContainerId { get; }

    /// <summary>
    /// </summary>
    string? DefinitionName { get; }

    /// <summary>
    /// </summary>
    string? DefinitionVersion { get; }

    /// <summary>
    /// </summary>
    string? QueuedBy { get; }

    /// <summary>
    /// </summary>
    string? QueuedById { get; }

    /// <summary>
    /// </summary>
    string? Reason { get; }

    /// <summary>
    /// </summary>
    string? RepositoryClean { get; }

    /// <summary>
    /// </summary>
    string? RepositoryLocalPath { get; }

    /// <summary>
    /// </summary>
    string? RepositoryID { get; }

    /// <summary>
    /// </summary>
    string? RepositoryName { get; }

    /// <summary>
    /// </summary>
    string? RepositoryProvider { get; }

    /// <summary>
    /// </summary>
    string? RepositoryTfvcWorkspace { get; }

    /// <summary>
    /// </summary>
    string? RepositoryUri { get; }

    /// <summary>
    /// </summary>
    string? RequestedFor { get; }

    /// <summary>
    /// </summary>
    string? RequestedForEmail { get; }

    /// <summary>
    /// </summary>
    string? RequestedForId { get; }

    /// <summary>
    /// </summary>
    string? SourceBranch { get; }

    /// <summary>
    /// </summary>
    string? SourceBranchName { get; }

    /// <summary>
    /// </summary>
    string? SourcesDirectory { get; }

    /// <summary>
    /// </summary>
    string? SourceVersion { get; }

    /// <summary>
    /// </summary>
    string? SourceVersionMessage { get; }

    /// <summary>
    /// </summary>
    string? StagingDirectory { get; }

    /// <summary>
    /// </summary>
    string? RepositoryGitSubmoduleCheckout { get; }

    /// <summary>
    /// </summary>
    string? SourceTfvcShelveset { get; }

    /// <summary>
    /// </summary>
    string? TriggeredByBuildId { get; }

    /// <summary>
    /// </summary>
    string? TriggeredByDefinitionId { get; }

    /// <summary>
    /// </summary>
    string? TriggeredByDefinitionName { get; }

    /// <summary>
    /// </summary>
    string? TriggeredByBuildNumber { get; }

    /// <summary>
    /// </summary>
    string? TriggeredByProjectId { get; }

    /// <summary>
    /// </summary>
    string? TestResultsDirectory { get; }

    /// <summary>
    /// </summary>
    string? ArtifactStagingDirectory { get; }
}