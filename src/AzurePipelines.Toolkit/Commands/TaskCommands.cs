namespace AzurePipelines.Toolkit.Commands;

using AzurePipelines.Toolkit.Extensions;

/// <inheritdoc />
internal sealed class TaskCommands : ITaskCommands
{
    private readonly AzurePipelinesToolkit toolkit;

    internal TaskCommands(AzurePipelinesToolkit toolkit)
    {
        this.toolkit = toolkit;
    }

    /// <inheritdoc />
    public void AddAttachment(string path, string type, string name)
    {
        this.toolkit.WriteCommand(
            "task.setvariable",
            path,
            new Dictionary<string, object>()
                .AddPair("type", type)
                .AddPair("name", name));
    }

    /// <inheritdoc />
    public void Complete(string message, string result)
    {
        this.toolkit.WriteCommand(
            "task.complete",
            message,
            new Dictionary<string, object>()
                .AddPair("result", result));
    }

    /// <inheritdoc />
    public void LogDetail(
        string message,
        string id,
        string? parentId = default,
        string? type = default,
        string? name = default,
        string? order = default,
        string? startTime = default,
        string? finishTime = default,
        string? progress = default,
        string? state = default,
        string? result = default)
    {
        this.toolkit.WriteCommand(
            "task.logdetail",
            message,
            new Dictionary<string, object>()
                .AddPair("id", id)
                .AddPairWhenValueNotNull("parentid", parentId)
                .AddPairWhenValueNotNull("type", type)
                .AddPairWhenValueNotNull("name", name)
                .AddPairWhenValueNotNull("order", order)
                .AddPairWhenValueNotNull("starttime", startTime)
                .AddPairWhenValueNotNull("finishtime", finishTime)
                .AddPairWhenValueNotNull("progress", progress)
                .AddPairWhenValueNotNull("state", state)
                .AddPairWhenValueNotNull("result", result));
    }

    /// <inheritdoc />
    public void LogIssue(
        string message,
        string type,
        string? sourcePath = default,
        uint? lineNumber = default,
        uint? columnNumber = default,
        int? code = default)
    {
        this.toolkit.WriteCommand(
            "task.logissue",
            message,
            new Dictionary<string, object>()
                .AddPair("type", type)
                .AddPairWhenValueNotNull("sourcepath", sourcePath)
                .AddPairWhenValueNotNull("linenumber", lineNumber)
                .AddPairWhenValueNotNull("columnnumber", columnNumber)
                .AddPairWhenValueNotNull("code", code));
    }

    /// <inheritdoc />
    public void PrependPath(string value)
    {
        this.toolkit.WriteCommand("task.prependpath", value);
    }

    /// <inheritdoc />
    public void SetEndpoint(
        string value,
        string id,
        string field,
        string? key = default)
    {
        this.toolkit.WriteCommand(
            "task.setendpoint",
            value,
            new Dictionary<string, object>()
                .AddPair("id", id)
                .AddPair("field", field)
                .AddPairWhenValueNotNull("key", key));
    }

    /// <inheritdoc />
    public void SetProgress(string message, uint value)
    {
        this.toolkit.WriteCommand(
            "task.setprogress",
            message,
            new Dictionary<string, object>()
                .AddPair("value", value));
    }

    /// <inheritdoc />
    public void SetVariable(
        string name,
        string value,
        bool? isSecret = default,
        bool? isOutput = default,
        bool? isReadOnly = default)
    {
        this.toolkit.WriteCommand(
            "task.setvariable",
            value,
            new Dictionary<string, object>()
                .AddPair("variable", name)
                .AddPairWhenValueNotNull("issecret", isSecret)
                .AddPairWhenValueNotNull("isoutput", isOutput)
                .AddPairWhenValueNotNull("isreadonly", isReadOnly));
    }

    /// <inheritdoc />
    public void UploadFile(string path)
    {
        this.toolkit.WriteCommand("task.uploadfile", path);
    }

    /// <inheritdoc />
    public void UploadSummary(string path)
    {
        this.toolkit.WriteCommand("task.uploadsummary", path);
    }
}