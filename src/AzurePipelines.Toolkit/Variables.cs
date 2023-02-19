namespace AzurePipelines.Toolkit;

/// <summary>
///     Azure Pipelines predefined environment variables.
///     <a href="https://learn.microsoft.com/en-us/azure/devops/pipelines/build/variables">See more</a>.
/// </summary>
public static class Variables
{
    public static class Agent
    {
        /// <summary>
        ///     The local path on the agent where all folders for a given build pipeline are created.
        ///     This variable has the same value as <see cref="Pipeline.Workspace" />.
        ///     <example>
        ///         <code>/home/vsts/work/1</code>
        ///     </example>
        /// </summary>
        public static string? BuildDirectory => EnvironmentInfo.GetVariable("AGENT_BUILDDIRECTORY");

        /// <summary>
        ///     A mapping from container resource names in YAML to their Docker IDs at runtime.
        ///     <example>
        ///         <code>
        ///         {
        ///           "one_container": {
        ///             "id": "bdbb357d73a0bd3550a1a5b778b62a4c88ed2051c7802a0659f1ff6e76910190"
        ///           },
        ///           "another_container": {
        ///             "id": "82652975109ec494876a8ccbb875459c945982952e0a72ad74c91216707162bb"
        ///           }
        ///         }
        ///  </code>
        ///     </example>
        /// </summary>
        public static string? ContainerMapping => EnvironmentInfo.GetVariable("AGENT_CONTAINERMAPPING");

        /// <summary>
        ///     The directory the agent is installed into.
        ///     This contains the agent software.
        ///     <example>
        ///         <code>c:\agent</code>
        ///     </example>
        /// </summary>
        public static string? HomeDirectory => EnvironmentInfo.GetVariable("AGENT_HOMEDIRECTORY");

        /// <summary>
        ///     The ID of the agent.
        /// </summary>
        public static string? Id => EnvironmentInfo.GetVariable("AGENT_ID");

        /// <summary>
        ///     The name of the running job.
        ///     This will usually be "Job" or "__default", but in multi-config scenarios, will be the configuration.
        /// </summary>
        public static string? JobName => EnvironmentInfo.GetVariable("AGENT_JOBNAME");

        /// <summary>
        ///     The status of the build.
        /// </summary>
        public static string? JobStatus => EnvironmentInfo.GetVariable("AGENT_JOBSTATUS");

        /// <summary>
        ///     The name of the machine on which the agent is installed.
        /// </summary>
        public static string? MachineName => EnvironmentInfo.GetVariable("AGENT_MACHINENAME");

        /// <summary>
        ///     The name of the agent that is registered with the pool.
        /// </summary>
        public static string? Name => EnvironmentInfo.GetVariable("AGENT_NAME");

        /// <summary>
        ///     The operating system of the agent host.
        ///     If you're running in a container, the agent host and container may be running different operating systems.
        /// </summary>
        public static string? OS => EnvironmentInfo.GetVariable("AGENT_OS");

        /// <summary>
        ///     The operating system processor architecture of the agent host.
        /// </summary>
        public static string? OSArchitecture => EnvironmentInfo.GetVariable("AGENT_OSARCHITECTURE");

        /// <summary>
        ///     A temporary folder that is cleaned after each pipeline job.
        ///     This directory is used by tasks such as .NET Core CLI task to hold temporary items like test results before they
        ///     are published.
        ///     <example>
        ///         <code>/home/vsts/work/_temp</code>
        ///     </example>
        /// </summary>
        public static string? TempDirectory => EnvironmentInfo.GetVariable("AGENT_TEMPDIRECTORY");

        /// <summary>
        ///     The directory used by tasks such as Node Tool Installer and Use Python Version to switch between multiple versions
        ///     of a tool.
        ///     These tasks will add tools from this directory to <code>PATH</code> so that subsequent build steps can use them.
        /// </summary>
        public static string? ToolsDirectory => EnvironmentInfo.GetVariable("AGENT_TOOLSDIRECTORY");

        /// <summary>
        ///     The working directory for this agent.
        ///     <example>
        ///         <code>c:\agent_work</code>
        ///     </example>
        /// </summary>
        public static string? WorkFolder => EnvironmentInfo.GetVariable("AGENT_WORKFOLDER");
    }

    public static class Build
    {
        public static string? BuildId = EnvironmentInfo.GetVariable("BUILD_BUILDID");

        public static string? BuildNumber = EnvironmentInfo.GetVariable("BUILD_BUILDNUMBER");

        public static string? BuildUri = EnvironmentInfo.GetVariable("BUILD_BUILDURI");

        public static string? BinariesDirectory = EnvironmentInfo.GetVariable("BUILD_BINARIESDIRECTORY");

        public static string? ContainerId = EnvironmentInfo.GetVariable("BUILD_CONTAINERID");

        public static string? DefinitionName = EnvironmentInfo.GetVariable("BUILD_DEFINITIONNAME");

        public static string? DefinitionVersion = EnvironmentInfo.GetVariable("BUILD_DEFINITIONVERSION");

        public static string? QueuedBy = EnvironmentInfo.GetVariable("BUILD_QUEUEDBY");

        public static string? QueuedById = EnvironmentInfo.GetVariable("BUILD_QUEUEDBYID");

        public static string? Reason = EnvironmentInfo.GetVariable("BUILD_REASON");

        public static string? RepositoryClean = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_CLEAN");

        public static string? RepositoryLocalPath = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_LOCALPATH");

        public static string? RepositoryID = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_ID");

        public static string? RepositoryName = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_NAME");

        public static string? RepositoryProvider = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_PROVIDER");

        public static string? RepositoryTfvcWorkspace = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_TVFC_WORKSPACE");

        public static string? RepositoryUri = EnvironmentInfo.GetVariable("BUILD_REPOSITORY_URI");

        public static string? RequestedFor = EnvironmentInfo.GetVariable("BUILD_REQUESTEDFOR");

        public static string? RequestedForEmail = EnvironmentInfo.GetVariable("BUILD_REQUESTEDFOREMAIL");

        public static string? RequestedForId = EnvironmentInfo.GetVariable("BUILD_REQUESTEDFORID");

        public static string? SourceBranch = EnvironmentInfo.GetVariable("BUILD_SOURCEBRANCH");

        public static string? SourceBranchName = EnvironmentInfo.GetVariable("BUILD_SOURCEBRANCHNAME");

        public static string? SourcesDirectory = EnvironmentInfo.GetVariable("BUILD_SOURCESDIRECTORY");

        public static string? SourceVersion = EnvironmentInfo.GetVariable("BUILD_SOURCEVERSION");

        public static string? SourceVersionMessage = EnvironmentInfo.GetVariable("BUILD_SOURCEVERSIONMESSAGE");

        public static string? StagingDirectory = EnvironmentInfo.GetVariable("BUILD_STAGINGDIRECTORY");

        public static string? RepositoryGitSubmoduleCheckout =
            EnvironmentInfo.GetVariable("BUILD_REPOSITORY_GIT_SUBMODULECHECKOUT");

        public static string? SourceTfvcShelveset = EnvironmentInfo.GetVariable("BUILD_SOURCETFVCSHELVESET");

        public static string? TriggeredByBuildId = EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_BUILDID");

        public static string? TriggeredByDefinitionId = EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_DEFINITIONID");

        public static string? TriggeredByDefinitionName =
            EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_DEFINITIONNAME");

        public static string? TriggeredByBuildNumber = EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_BUILDNUMBER");

        public static string? TriggeredByProjectID = EnvironmentInfo.GetVariable("BUILD_TRIGGEREDBY_PROJECTID");

        public static string? TestResultsDirectory = EnvironmentInfo.GetVariable("COMMON_TESTRESULTSDIRECTORY");

        public static string? ArtifactStagingDirectory => EnvironmentInfo.GetVariable("BUILD_ARTIFACTSTAGINGDIRECTORY");
    }

    public static class Pipeline
    {
        /// <summary>
        ///     Workspace directory for a particular pipeline.
        ///     This variable has the same value as <see cref="Agent.BuildDirectory" />.
        ///     <example>
        ///         <code>/home/vsts/work/1</code>
        ///     </example>
        /// </summary>
        public static string? Workspace = EnvironmentInfo.GetVariable("PIPELINE_WORKSPACE");
    }

    /// <summary>
    ///     These variables are scoped to a specific Deployment job and will be resolved only at job execution time.
    /// </summary>
    public static class Deployment
    {
        /// <summary>
        ///     Name of the environment targeted in the deployment job to run the deployment steps and record the deployment
        ///     history.
        ///     <example>
        ///         <code>smarthotel-dev</code>
        ///     </example>
        /// </summary>
        public static string? EnvironmentName = EnvironmentInfo.GetVariable("ENVIRONMENT_NAME");

        /// <summary>
        ///     ID of the environment targeted in the deployment job.
        ///     <example>10</example>
        /// </summary>
        public static string? EnvironmentId = EnvironmentInfo.GetVariable("ENVIRONMENT_ID");

        /// <summary>
        ///     Name of the specific resource within the environment targeted in the deployment job to run the deployment steps and
        ///     record the deployment history.
        ///     <example>
        ///         <code>bookings</code>
        ///     </example>
        /// </summary>
        public static string? EnvironmentResourceName = EnvironmentInfo.GetVariable("ENVIRONMENT_RESOURCENAME");

        /// <summary>
        ///     ID of the specific resource within the environment targeted in the deployment job to run the deployment steps.
        ///     <example>
        ///         <code>4</code>
        ///     </example>
        /// </summary>
        public static string? EnvironmentResourceId = EnvironmentInfo.GetVariable("ENVIRONMENT_RESOURCEID");

        /// <summary>
        ///     The name of the deployment strategy.
        /// </summary>
        public static string? StrategyName = EnvironmentInfo.GetVariable("STRATEGY_NAME");

        /// <summary>
        ///     The current cycle name in a deployment.
        /// </summary>
        public static string? StrategyCycleName = EnvironmentInfo.GetVariable("STRATEGY_CYCLENAME");
    }

    public static class System
    {
        public static string? AccessToken = EnvironmentInfo.GetVariable("SYSTEM_ACCESSTOKEN");

        public static string? CollectionId = EnvironmentInfo.GetVariable("SYSTEM_COLLECTIONID");

        public static string? CollectionUri = EnvironmentInfo.GetVariable("SYSTEM_COLLECTIONURI");

        public static string? DefaultWorkingDirectory = EnvironmentInfo.GetVariable("SYSTEM_DEFAULTWORKINGDIRECTORY");

        public static string? DefinitionId = EnvironmentInfo.GetVariable("SYSTEM_DEFINITIONID");

        public static string? HostType = EnvironmentInfo.GetVariable("SYSTEM_HOSTTYPE");

        public static string? JobAttempt = EnvironmentInfo.GetVariable("SYSTEM_JOBATTEMPT");

        public static string? JobDisplayName = EnvironmentInfo.GetVariable("SYSTEM_JOBDISPLAYNAME");

        public static string? JobId = EnvironmentInfo.GetVariable("SYSTEM_JOBID");

        public static string? JobName = EnvironmentInfo.GetVariable("SYSTEM_JOBNAME");

        public static string? PhaseAttempt = EnvironmentInfo.GetVariable("SYSTEM_PHASEATTEMPT");

        public static string? PhaseDisplayName = EnvironmentInfo.GetVariable("SYSTEM_PHASEDISPLAYNAME");

        public static string? PhaseName = EnvironmentInfo.GetVariable("SYSTEM_PHASENAME");

        public static string? PlanId = EnvironmentInfo.GetVariable("SYSTEM_PLANID");

        public static string? PullRequestIsFork = EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_ISFORK");

        public static string? PullRequestPullRequestId =
            EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_PULLREQUESTID");

        public static string? PullRequestPullRequestNumber =
            EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_PULLREQUESTNUMBER");

        public static string? PullRequestSourceBranch = EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_SOURCEBRANCH");

        public static string? PullRequestSourceRepositoryURI =
            EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_SOURCEREPOSITORYURI");

        public static string? PullRequestTargetBranch = EnvironmentInfo.GetVariable("SYSTEM_PULLREQUEST_TARGETBRANCH");

        public static string? StageAttempt = EnvironmentInfo.GetVariable("SYSTEM_STAGEATTEMPT");

        public static string? StageDisplayName = EnvironmentInfo.GetVariable("SYSTEM_STAGEDISPLAYNAME");

        public static string? StageName = EnvironmentInfo.GetVariable("SYSTEM_STAGENAME");

        public static string? TeamFoundationCollectionUri =
            EnvironmentInfo.GetVariable("SYSTEM_TEAMFOUNDATIONCOLLECTIONURI");

        public static string? TeamProject = EnvironmentInfo.GetVariable("SYSTEM_TEAMPROJECT");

        public static string? TeamProjectId = EnvironmentInfo.GetVariable("SYSTEM_TEAMPROJECTID");

        public static string? TimelineId = EnvironmentInfo.GetVariable("SYSTEM_TIMELINEID");

        public static string? TfBuild = EnvironmentInfo.GetVariable("TF_BUILD");
    }

    public static class Checks
    {
        public static string? StageAttempt = EnvironmentInfo.GetVariable("CHECKS_STAGEATTEMPT");
    }
}