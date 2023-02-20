namespace AzurePipelines.Toolkit.Commands;

internal sealed class FormattingCommands : IFormattingCommands
{
    private readonly Action<string> sink;

    internal FormattingCommands(Action<string> toolkit)
    {
        this.sink = toolkit;
    }

    /// <inheritdoc />
    public void Group(string group)
    {
        this.sink($"##[group]{group}");
    }

    /// <inheritdoc />
    public void EndGroup()
    {
        this.sink($"##[endgroup]");
    }

    /// <inheritdoc />
    public void Warning(string message)
    {
        this.sink($"##[warning]{message}");
    }

    /// <inheritdoc />
    public void Error(string message)
    {
        this.sink($"##[error]{message}");
    }

    /// <inheritdoc />
    public void Debug(string message)
    {
        this.sink($"##[debug]{message}");
    }

    /// <inheritdoc />
    public void Section(string message)
    {
        this.sink($"##[section]{message}");
    }

    /// <inheritdoc />
    public void Command(string message)
    {
        this.sink($"##[command]{message}");
    }
}