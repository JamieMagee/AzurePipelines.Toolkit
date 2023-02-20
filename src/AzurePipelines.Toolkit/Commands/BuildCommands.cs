namespace AzurePipelines.Toolkit.Commands;

/// <inheritdoc />
internal sealed class BuildCommands : IBuildCommands
{
    private readonly AzurePipelinesToolkit toolkit;

    internal BuildCommands(AzurePipelinesToolkit toolkit)
    {
        this.toolkit = toolkit;
    }

    /// <inheritdoc />
    public void AddBuildTag(string buildTag)
    {
        this.toolkit.WriteCommand("build.addbuildtag", buildTag);
    }

    /// <inheritdoc />
    public void UpdateBuildNumber(string buildNumber)
    {
        this.toolkit.WriteCommand("build.updatebuildnumber", buildNumber);
    }

    /// <inheritdoc />
    public void UploadLog(string path)
    {
        this.toolkit.WriteCommand("build.uploadlog", path);
    }
}