namespace AzurePipelines.Toolkit.Commands;

/// <summary>
/// </summary>
public interface IFormattingCommands
{
    /// <summary>
    /// </summary>
    /// <param name="group"></param>
    void Group(string group);

    /// <summary>
    /// </summary>
    void EndGroup();

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    void Warning(string message);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    void Error(string message);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    void Debug(string message);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    void Section(string message);

    /// <summary>
    /// </summary>
    /// <param name="message"></param>
    void Command(string message);
}