namespace AzurePipelines.Toolkit.Test.Commands;

using Moq;
using Xunit;

public sealed class FormattingCommandsTests
{
    private readonly Mock<Action<string>> sink;
    private readonly IAzurePipelinesToolkit toolkit;

    public FormattingCommandsTests()
    {
        this.sink = new Mock<Action<string>>();
        this.toolkit = new AzurePipelinesToolkit(this.sink.Object);
    }

    [Fact]
    public void StartGroupTests()
    {
        const string groupName = "group name";
        this.toolkit.Format.Group(groupName);

        this.sink.Verify(x => x.Invoke($"##[group]{groupName}"), Times.Once);
    }

    [Fact]
    public void EndGroupTests()
    {
        this.toolkit.Format.EndGroup();

        this.sink.Verify(x => x.Invoke("##[endgroup]"), Times.Once);
    }

    [Fact]
    public void WarningTests()
    {
        const string warningMessage = "warning message";
        this.toolkit.Format.Warning(warningMessage);

        this.sink.Verify(x => x.Invoke($"##[warning]{warningMessage}"), Times.Once);
    }

    [Fact]
    public void ErrorTests()
    {
        const string errorMessage = "error message";
        this.toolkit.Format.Error(errorMessage);

        this.sink.Verify(x => x.Invoke($"##[error]{errorMessage}"), Times.Once);
    }

    [Fact]
    public void DebugTests()
    {
        const string debugMessage = "debug message";
        this.toolkit.Format.Debug(debugMessage);

        this.sink.Verify(x => x.Invoke($"##[debug]{debugMessage}"), Times.Once);
    }

    [Fact]
    public void SectionTests()
    {
        const string section = "section";
        this.toolkit.Format.Section(section);

        this.sink.Verify(x => x.Invoke($"##[section]{section}"), Times.Once);
    }

    [Fact]
    public void CommandTests()
    {
        const string command = "command";
        this.toolkit.Format.Command(command);

        this.sink.Verify(x => x.Invoke($"##[command]{command}"), Times.Once);
    }
}