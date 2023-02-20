namespace AzurePipelines.Toolkit.Test.Commands;

using Moq;

public sealed class TaskCommandsTests
{
    private readonly Mock<Action<string>> sink;
    private readonly IAzurePipelinesToolkit toolkit;

    public TaskCommandsTests()
    {
        this.sink = new Mock<Action<string>>();
        this.toolkit = new AzurePipelinesToolkit(this.sink.Object);
    }
}