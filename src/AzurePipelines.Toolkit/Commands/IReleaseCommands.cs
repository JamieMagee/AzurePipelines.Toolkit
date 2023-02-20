namespace AzurePipelines.Toolkit.Commands;

/// <summary>
/// </summary>
public interface IReleaseCommands
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/azure/devops/pipelines/scripts/logging-commands?view=azure-devops&amp;tabs=bash#updatereleasename-rename-current-release.
    /// </summary>
    /// <param name="name"></param>
    void UpdateReleaseName(string name);
}