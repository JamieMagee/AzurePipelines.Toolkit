namespace AzurePipelines.Toolkit.Commands;

/// <summary>
/// </summary>
public interface ITaskCommands
{
    /// <summary>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    void AddAttachment(string path, string type, string name);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="result"></param>
    void Complete(string message, string result);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="id"></param>
    /// <param name="parentId"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="order"></param>
    /// <param name="startTime"></param>
    /// <param name="finishTime"></param>
    /// <param name="progress"></param>
    /// <param name="state"></param>
    /// <param name="result"></param>
    void LogDetail(
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
        string? result = default);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="type"></param>
    /// <param name="sourcePath"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="code"></param>
    void LogIssue(
        string message,
        string type,
        string? sourcePath = default,
        uint? lineNumber = default,
        uint? columnNumber = default,
        int? code = default);

    /// <summary>
    /// </summary>
    /// <param name="value"></param>
    void PrependPath(string value);


    /// <summary>
    /// </summary>
    /// <param name="value"></param>
    /// <param name="id"></param>
    /// <param name="field"></param>
    /// <param name="key"></param>
    void SetEndpoint(
        string value,
        string id,
        string field,
        string? key = default);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="value"></param>
    void SetProgress(string message, uint value);

    /// <summary>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="isSecret"></param>
    /// <param name="isOutput"></param>
    /// <param name="isReadOnly"></param>
    void SetVariable(
        string name,
        string value,
        bool? isSecret = default,
        bool? isOutput = default,
        bool? isReadOnly = default);

    /// <summary>
    /// </summary>
    /// <param name="path"></param>
    void UploadFile(string path);

    /// <inheritdoc />
    void UploadSummary(string path);
}