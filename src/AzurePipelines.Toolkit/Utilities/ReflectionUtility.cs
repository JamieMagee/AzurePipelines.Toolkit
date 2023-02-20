using System.ComponentModel;

namespace AzurePipelines.Toolkit.Utilities;

internal static class ReflectionUtility
{
    public static T? Convert<T>(string value)
    {
        return (T?)Convert(value, typeof(T));
    }

    public static object? Convert(object value, Type destinationType)
    {
        if (destinationType.IsInstanceOfType(value))
        {
            return value;
        }

        if (destinationType == typeof(string) && value == null)
        {
            return null;
        }

        try
        {
            var typeConverter = TypeDescriptor.GetConverter(destinationType);
            return typeConverter.ConvertFromInvariantString(value?.ToString());
        }
        catch
        {
            throw new ArgumentOutOfRangeException($"Value '{value}' could not be converted to '{destinationType.FullName}'");
        }
    }
}