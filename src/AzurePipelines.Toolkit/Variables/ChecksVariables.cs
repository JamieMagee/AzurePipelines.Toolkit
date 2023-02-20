namespace AzurePipelines.Toolkit.Variables;

using AzurePipelines.Toolkit.Utilities;

/// <inheritdoc />
internal sealed class ChecksVariables : IChecksVariables
{
    /// <inheritdoc />
    public string? StageAttempt => EnvironmentInfo.GetVariable("CHECKS_STAGEATTEMPT");
}