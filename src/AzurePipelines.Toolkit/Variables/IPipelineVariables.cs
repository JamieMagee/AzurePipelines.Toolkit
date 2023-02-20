namespace AzurePipelines.Toolkit.Variables;

/// <summary>
/// </summary>
public interface IPipelineVariables
{
    /// <summary>
    ///     Workspace directory for a particular pipeline.
    ///     This variable has the same value as <see cref="AgentVariables.BuildDirectory" />.
    ///     <example>
    ///         <code>/home/vsts/work/1</code>
    ///     </example>
    /// </summary>
    string? Workspace { get; }
}