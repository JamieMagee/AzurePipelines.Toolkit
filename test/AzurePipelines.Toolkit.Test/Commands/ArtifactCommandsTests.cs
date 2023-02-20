namespace AzurePipelines.Toolkit.Test.Commands;

using Moq;
using Xunit;

public class ArtifactCommandsTests
{
    private readonly Mock<Action<string>> sink;
    private readonly IAzurePipelinesToolkit toolkit;

    public ArtifactCommandsTests()
    {
        this.sink = new Mock<Action<string>>();
        this.toolkit = new AzurePipelinesToolkit(this.sink.Object);
    }

    [Theory]
    [InlineData("#/1/build", "MyServerDrop", "container")]
    public void AssociateTests(string path, string artifactName, string type)
    {
        this.toolkit.Artifact.Associate(path, artifactName, type);

        this.sink.Verify(
            x => x.Invoke($"##vso[artifact.associate artifactname={artifactName};type={type}]{path}"),
            Times.Once);
    }

    [Theory]
    [InlineData("c:\\testresult.trx", "testresult", "uploadedresult")]
    public void UploadTests(string path, string containerFolder, string artifactName)
    {
        this.toolkit.Artifact.Upload(path, artifactName, containerFolder);

        this.sink.Verify(
            x => x.Invoke(
                $"##vso[artifact.upload artifactname={artifactName};containerfolder={containerFolder}]{path}"),
            Times.Once);
    }
}