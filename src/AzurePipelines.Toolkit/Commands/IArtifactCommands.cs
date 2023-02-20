namespace AzurePipelines.Toolkit.Commands;

/// <summary>
/// </summary>
public interface IArtifactCommands
{
    /// <summary>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="artifactName"></param>
    /// <param name="type"></param>
    void Associate(string path, string artifactName, string type);

    /// <summary>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="artifactName"></param>
    /// <param name="containerFolder"></param>
    void Upload(string path, string artifactName, string? containerFolder = default);
}