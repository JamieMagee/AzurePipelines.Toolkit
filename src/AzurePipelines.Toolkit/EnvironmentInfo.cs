namespace AzurePipelines.Toolkit;

public static class EnvironmentInfo
{
    public static string? GetVariable(string name)
    {
        return Environment.GetEnvironmentVariable(name);
    }
}