namespace AzurePipelines.Toolkit.Test.Commands.TestData;

using AzurePipelines.Toolkit.Models;
using Xunit;

public sealed class ArtifactCommandsTestData
{
    public static TheoryData<string, string, ArtifactType> AssociateData =>
        new()
        {
            { "#/1/build", "MyServerDrop", ArtifactType.Container },
            { "\\\\MyShare\\MyDropLocation", "MyFileShareDrop", ArtifactType.FilePath },
            { "$/MyTeamProj/MyFolder", "MyTfvcPath", ArtifactType.VersionControl },
            { "refs/tags/MyGitTag", "MyTag", ArtifactType.VersionControl },
            { "MyTfvcLabel", "MyTag", ArtifactType.TfvcLabel },
        };

    public static TheoryData<string, string, string> UploadData =>
        new()
        {
            { "c:\\testresult.trx", "testresult", "uploadedresult" },
        };
}