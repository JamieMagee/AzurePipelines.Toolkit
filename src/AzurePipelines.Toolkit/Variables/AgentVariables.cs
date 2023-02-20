namespace AzurePipelines.Toolkit.Variables;

using AzurePipelines.Toolkit.Utilities;

/// <inheritdoc />
internal sealed class AgentVariables : IAgentVariables
{
    /// <inheritdoc />
    public string? BuildDirectory => EnvironmentInfo.GetVariable("AGENT_BUILDDIRECTORY");

    /// <inheritdoc />
    public string? ContainerMapping => EnvironmentInfo.GetVariable("AGENT_CONTAINERMAPPING");

    /// <inheritdoc />
    public string? HomeDirectory => EnvironmentInfo.GetVariable("AGENT_HOMEDIRECTORY");

    /// <inheritdoc />
    public string? Id => EnvironmentInfo.GetVariable("AGENT_ID");

    /// <inheritdoc />
    public string? JobName => EnvironmentInfo.GetVariable("AGENT_JOBNAME");

    /// <inheritdoc />
    public string? JobStatus => EnvironmentInfo.GetVariable("AGENT_JOBSTATUS");

    /// <inheritdoc />
    public string? MachineName => EnvironmentInfo.GetVariable("AGENT_MACHINENAME");

    /// <inheritdoc />
    public string? Name => EnvironmentInfo.GetVariable("AGENT_NAME");

    /// <inheritdoc />
    public string? OS => EnvironmentInfo.GetVariable("AGENT_OS");

    /// <inheritdoc />
    public string? OSArchitecture => EnvironmentInfo.GetVariable("AGENT_OSARCHITECTURE");

    /// <inheritdoc />
    public string? TempDirectory => EnvironmentInfo.GetVariable("AGENT_TEMPDIRECTORY");

    /// <inheritdoc />
    public string? ToolsDirectory => EnvironmentInfo.GetVariable("AGENT_TOOLSDIRECTORY");

    /// <inheritdoc />
    public string? WorkFolder => EnvironmentInfo.GetVariable("AGENT_WORKFOLDER");
}