namespace AzurePipelines.Toolkit.Variables;

using AzurePipelines.Toolkit.Utilities;

/// <inheritdoc />
internal sealed class BuildVariables : IBuildVariables
{
    /// <inheritdoc />
    public string? BuildId => EnvironmentInfo.GetVariable("BUILD_BUILDID");

    /// <inheritdoc />
    public string? BuildNumber => EnvironmentInfo.GetVariable("BUILD_BUILDNUMBER");

    /// <inheritdoc />
    public string? BuildUri => EnvironmentInfo.GetVariable("BUILD_BUILDURI");

    /// <inheritdoc />
    public string? BinariesDirectory => EnvironmentInfo.GetVariable("BUILD_BINARIESDIRECTORY");

    /// <inheritdoc />
    public string? ContainerId => EnvironmentInfo.GetVariable("BUILD_CONTAINERID");

    /// <inheritdoc />
    public string? DefinitionName => EnvironmentInfo.GetVariable("BUILD_DEFINITIONNAME");

    /// <inheritdoc />
    public string? DefinitionVersion => EnvironmentInfo.GetVariable("BUILD_DEFINITIONVERSION");

    /// <inheritdoc />
    public string? QueuedBy => EnvironmentInfo.GetVariable("BUILD_QUEUEDBY");

    /// <inheritdoc />
    public string? QueuedById => EnvironmentInfo.GetVariable("BUILD_QUEUEDBYID");

    /// <inheritdoc />
    public string? Reason => EnvironmentInfo.GetVariable("BUILD_REASON");

    /// <inheritdoc />
    public string? RepositoryClean => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_CLEAN");

    /// <inheritdoc />
    public string? RepositoryLocalPath => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_LOCALPATH");

    /// <inheritdoc />
    public string? RepositoryID => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_ID");

    /// <inheritdoc />
    public string? RepositoryName => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_NAME");

    /// <inheritdoc />
    public string? RepositoryProvider => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_PROVIDER");

    /// <inheritdoc />
    public string? RepositoryTfvcWorkspace => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_TVFC_WORKSPACE");

    /// <inheritdoc />
    public string? RepositoryUri => EnvironmentInfo.GetVariable("BUILD_REPOSITORY_URI");

    /// <inheritdoc />
    public string? RequestedFor => EnvironmentInfo.GetVariable("BUILD_REQUESTEDFOR");

    /// <inheritdoc />
    public string? RequestedForEmail => EnvironmentInfo.GetVariable("BUILD_REQUESTEDFOREMAIL");

    /// <inheritdoc />
    public string? RequestedForId => EnvironmentInfo.GetVariable("BUILD_REQUESTEDFORID");

    /// <inheritdoc />
    public string? SourceBranch => EnvironmentInfo.GetVariable("BUILD_SOURCEBRANCH");

    /// <inheritdoc />
    public string? SourceBranchName => EnvironmentInfo.GetVariable("BUILD_SOURCEBRANCHNAME");

    /// <inheritdoc />
    public string? SourcesDirectory => EnvironmentInfo.GetVariable("BUILD_SOURCESDIRECTORY");

    /// <inheritdoc />
    public string? SourceVersion => EnvironmentInfo.GetVariable("BUILD_SOURCEVERSION");

    /// <inheritdoc />
    public string? SourceVersionMessage => EnvironmentInfo.GetVariable("BUILD_SOURCEVERSIONMESSAGE");

    /// <inheritdoc />
    public string? StagingDirectory => EnvironmentInfo.GetVariable("BUILD_STAGINGDIRECTORY");

    /// <inheritdoc />
    public string? RepositoryGitSubmoduleCheckout =>
        EnvironmentInfo.GetVariable("BUILD_REPOSITORY_GIT_SUBMODULECHECKOUT");

    /// <inheritdoc />
    public string? SourceTfvcShelveset => EnvironmentInfo.GetVariable("BUILD_SOURCETFVCSHELVESET");

    /// <inheritdoc />
    public string? TriggeredByBuildId => EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_BUILDID");

    /// <inheritdoc />
    public string? TriggeredByDefinitionId => EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_DEFINITIONID");

    /// <inheritdoc />
    public string? TriggeredByDefinitionName =>
        EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_DEFINITIONNAME");

    /// <inheritdoc />
    public string? TriggeredByBuildNumber => EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_BUILDNUMBER");

    /// <inheritdoc />
    public string? TriggeredByProjectId => EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_PROJECTID");

    /// <inheritdoc />
    public string? TestResultsDirectory => EnvironmentInfo.GetVariable("COMMON_TESTRESULTSDIRECTORY");

    /// <inheritdoc />
    public string? ArtifactStagingDirectory => EnvironmentInfo.GetVariable("BUILD_ARTIFACTSTAGINGDIRECTORY");
}