using AzurePipelines.Toolkit.Utilities;

namespace AzurePipelines.Toolkit.Variables;

internal sealed class SystemVariables : ISystemVariables
{
    public string? AccessToken => EnvironmentInfo.GetVariable("SYSTEM_ACCESSTOKEN");

    public string? CollectionId => EnvironmentInfo.GetVariable("SYSTEM_COLLECTIONID");

    public string? CollectionUri => EnvironmentInfo.GetVariable("SYSTEM_COLLECTIONURI");

    public string? DefaultWorkingDirectory => EnvironmentInfo.GetVariable("SYSTEM_DEFAULTWORKINGDIRECTORY");

    public string? DefinitionId => EnvironmentInfo.GetVariable("SYSTEM_DEFINITIONID");

    public string? HostType => EnvironmentInfo.GetVariable("SYSTEM_HOSTTYPE");

    public string? JobAttempt => EnvironmentInfo.GetVariable("SYSTEM_JOBATTEMPT");

    public string? JobDisplayName => EnvironmentInfo.GetVariable("SYSTEM_JOBDISPLAYNAME");

    public string? JobId => EnvironmentInfo.GetVariable("SYSTEM_JOBID");

    public string? JobName => EnvironmentInfo.GetVariable("SYSTEM_JOBNAME");

    public string? PhaseAttempt => EnvironmentInfo.GetVariable("SYSTEM_PHASEATTEMPT");

    public string? PhaseDisplayName => EnvironmentInfo.GetVariable("SYSTEM_PHASEDISPLAYNAME");

    public string? PhaseName => EnvironmentInfo.GetVariable("SYSTEM_PHASENAME");

    public string? PlanId => EnvironmentInfo.GetVariable("SYSTEM_PLANID");

    public string? PullRequestIsFork => EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_ISFORK");

    public string? PullRequestPullRequestId =>
        EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_PULLREQUESTID");

    public string? PullRequestPullRequestNumber =>
        EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_PULLREQUESTNUMBER");

    public string? PullRequestSourceBranch => EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_SOURCEBRANCH");

    public string? PullRequestSourceRepositoryURI =>
        EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_SOURCEREPOSITORYURI");

    public string? PullRequestTargetBranch => EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_TARGETBRANCH");

    public string? StageAttempt => EnvironmentInfo.GetVariable("SYSTEM_STAGEATTEMPT");

    public string? StageDisplayName => EnvironmentInfo.GetVariable("SYSTEM_STAGEDISPLAYNAME");

    public string? StageName => EnvironmentInfo.GetVariable("SYSTEM_STAGENAME");

    public string? TeamFoundationCollectionUri =>
        EnvironmentInfo.GetVariable("SYSTEM_TEAMFOUNDATIONCOLLECTIONURI");

    public string? TeamProject => EnvironmentInfo.GetVariable("SYSTEM_TEAMPROJECT");

    public string? TeamProjectId => EnvironmentInfo.GetVariable("SYSTEM_TEAMPROJECTID");

    public string? TimelineId => EnvironmentInfo.GetVariable("SYSTEM_TIMELINEID");

    public string? TfBuild => EnvironmentInfo.GetVariable("TF_BUILD");
}