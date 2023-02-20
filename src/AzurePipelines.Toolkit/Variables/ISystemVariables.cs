namespace AzurePipelines.Toolkit.Variables;

public interface ISystemVariables
{
    string? AccessToken { get; }
    string? CollectionId { get; }
    string? CollectionUri { get; }
    string? DefaultWorkingDirectory { get; }
    string? DefinitionId { get; }
    string? HostType { get; }
    string? JobAttempt { get; }
    string? JobDisplayName { get; }
    string? JobId { get; }
    string? JobName { get; }
    string? PhaseAttempt { get; }
    string? PhaseDisplayName { get; }
    string? PhaseName { get; }
    string? PlanId { get; }
    string? PullRequestIsFork { get; }
    string? PullRequestPullRequestId { get; }
    string? PullRequestPullRequestNumber { get; }
    string? PullRequestSourceBranch { get; }
    string? PullRequestSourceRepositoryURI { get; }
    string? PullRequestTargetBranch { get; }
    string? StageAttempt { get; }
    string? StageDisplayName { get; }
    string? StageName { get; }
    string? TeamFoundationCollectionUri { get; }
    string? TeamProject { get; }
    string? TeamProjectId { get; }
    string? TimelineId { get; }
    string? TfBuild { get; }
}