namespace AzurePipelines.Toolkit.Utilities;

internal static class EnvironmentInfo
{
    internal static string? GetVariable(string name)
    {
        return Environment.GetEnvironmentVariable(name);
    }

    internal static T? GetVariable<T>(string name)
    {
        var value = GetVariable(name);
        if (value == null)
        {
            return default;
        }

        return ReflectionUtility.Convert<T>(value);
    }
}