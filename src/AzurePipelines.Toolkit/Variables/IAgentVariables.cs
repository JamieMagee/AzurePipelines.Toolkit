namespace AzurePipelines.Toolkit.Variables;

/// <summary>
/// </summary>
public interface IAgentVariables
{
    /// <summary>
    ///     The local path on the agent where all folders for a given build pipeline are created.
    ///     This variable has the same value as <see cref="Pipeline.Workspace" />.
    ///     <example>
    ///         <code>/home/vsts/work/1</code>
    ///     </example>
    /// </summary>
    string? BuildDirectory { get; }

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
    string? ContainerMapping { get; }

    /// <summary>
    ///     The directory the agent is installed into.
    ///     This contains the agent software.
    ///     <example>
    ///         <code>c:\agent</code>
    ///     </example>
    /// </summary>
    string? HomeDirectory { get; }

    /// <summary>
    ///     The ID of the agent.
    /// </summary>
    string? Id { get; }

    /// <summary>
    ///     The name of the running job.
    ///     This will usually be "Job" or "__default", but in multi-config scenarios, will be the configuration.
    /// </summary>
    string? JobName { get; }

    /// <summary>
    ///     The status of the build.
    /// </summary>
    string? JobStatus { get; }

    /// <summary>
    ///     The name of the machine on which the agent is installed.
    /// </summary>
    string? MachineName { get; }

    /// <summary>
    ///     The name of the agent that is registered with the pool.
    /// </summary>
    string? Name { get; }

    /// <summary>
    ///     The operating system of the agent host.
    ///     If you're running in a container, the agent host and container may be running different operating systems.
    /// </summary>
    string? OS { get; }

    /// <summary>
    ///     The operating system processor architecture of the agent host.
    /// </summary>
    string? OSArchitecture { get; }

    /// <summary>
    ///     A temporary folder that is cleaned after each pipeline job.
    ///     This directory is used by tasks such as .NET Core CLI task to hold temporary items like test results before they
    ///     are published.
    ///     <example>
    ///         <code>/home/vsts/work/_temp</code>
    ///     </example>
    /// </summary>
    string? TempDirectory { get; }

    /// <summary>
    ///     The directory used by tasks such as Node Tool Installer and Use Python Version to switch between multiple versions
    ///     of a tool.
    ///     These tasks will add tools from this directory to <code>PATH</code> so that subsequent build steps can use them.
    /// </summary>
    string? ToolsDirectory { get; }

    /// <summary>
    ///     The working directory for this agent.
    ///     <example>
    ///         <code>c:\agent_work</code>
    ///     </example>
    /// </summary>
    string? WorkFolder { get; }
}