namespace AzurePipelines.Toolkit.Commands;

using AzurePipelines.Toolkit.Extensions;
using AzurePipelines.Toolkit.Models;

/// <inheritdoc />
internal sealed class ArtifactCommands : IArtifactCommands
{
    private readonly AzurePipelinesToolkit toolkit;

    internal ArtifactCommands(AzurePipelinesToolkit toolkit)
    {
        this.toolkit = toolkit;
    }

    /// <inheritdoc />
    public void Associate(string path, string artifactName, ArtifactType type)
    {
        this.toolkit.WriteCommand(
            "artifact.associate",
            path,
            new Dictionary<string, object>()
                .AddPair("artifactname", artifactName)
                .AddPair("type", type.GetText()));
    }

    /// <inheritdoc />
    public void Upload(string path, string artifactName, string? containerFolder = default)
    {
        this.toolkit.WriteCommand(
            "artifact.upload",
            path,
            new Dictionary<string, object>()
                .AddPair("artifactname", artifactName)
                .AddPairWhenValueNotNull("containerfolder", containerFolder));
    }
}