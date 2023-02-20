namespace AzurePipelines.Toolkit.Utilities;

internal static class EnvironmentInfo
{
    internal static string? GetVariable(string name)
    {
        return Environment.GetEnvironmentVariable(name);
    }
}