namespace AzurePipelines.Toolkit.Commands;

using AzurePipelines.Toolkit.Models;

/// <summary>
/// </summary>
public interface IArtifactCommands
{
    /// <summary>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="artifactName"></param>
    /// <param name="type"></param>
    void Associate(string path, string artifactName, ArtifactType type);

    /// <summary>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="artifactName"></param>
    /// <param name="containerFolder"></param>
    void Upload(string path, string artifactName, string? containerFolder = default);
}