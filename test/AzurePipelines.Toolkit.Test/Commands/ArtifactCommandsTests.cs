namespace AzurePipelines.Toolkit.Test.Commands;

using AzurePipelines.Toolkit.Extensions;
using AzurePipelines.Toolkit.Models;
using AzurePipelines.Toolkit.Test.Commands.TestData;
using Moq;
using Xunit;

public sealed class ArtifactCommandsTests
{
    private readonly Mock<Action<string>> sink;
    private readonly IAzurePipelinesToolkit toolkit;

    public ArtifactCommandsTests()
    {
        this.sink = new Mock<Action<string>>();
        this.toolkit = new AzurePipelinesToolkit(this.sink.Object);
    }

    [Theory]
    [MemberData(nameof(ArtifactCommandsTestData.AssociateData), MemberType = typeof(ArtifactCommandsTestData))]
    public void AssociateTests(string path, string artifactName, ArtifactType type)
    {
        this.toolkit.Artifact.Associate(path, artifactName, type);

        this.sink.Verify(
            x => x.Invoke($"##vso[artifact.associate artifactname={artifactName};type={type.GetText()}]{path}"),
            Times.Once);
    }

    [Theory]
    [MemberData(nameof(ArtifactCommandsTestData.UploadData), MemberType = typeof(ArtifactCommandsTestData))]
    public void UploadTests(string path, string containerFolder, string artifactName)
    {
        this.toolkit.Artifact.Upload(path, artifactName, containerFolder);

        this.sink.Verify(
            x => x.Invoke(
                $"##vso[artifact.upload artifactname={artifactName};containerfolder={containerFolder}]{path}"),
            Times.Once);
    }
}
