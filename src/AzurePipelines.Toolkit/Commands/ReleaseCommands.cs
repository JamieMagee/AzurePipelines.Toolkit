namespace AzurePipelines.Toolkit.Commands;

/// <inheritdoc />
internal sealed class ReleaseCommands : IReleaseCommands
{
    private readonly AzurePipelinesToolkit toolkit;

    internal ReleaseCommands(AzurePipelinesToolkit toolkit)
    {
        this.toolkit = toolkit;
    }

    /// <inheritdoc />
    public void UpdateReleaseName(string name)
    {
        this.toolkit.WriteCommand("release.updatereleasename", name);
    }
}