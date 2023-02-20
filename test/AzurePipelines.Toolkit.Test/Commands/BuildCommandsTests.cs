namespace AzurePipelines.Toolkit.Test.Commands;

using Moq;

public sealed class BuildCommandsTests
{
    private readonly Mock<Action<string>> sink;
    private readonly IAzurePipelinesToolkit toolkit;

    public BuildCommandsTests()
    {
        this.sink = new Mock<Action<string>>();
        this.toolkit = new AzurePipelinesToolkit(this.sink.Object);
    }
}