namespace AzurePipelines.Toolkit.Commands;

/// <summary>
/// 
/// </summary>
public interface IBuildCommands
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="buildTag"></param>
    void AddBuildTag(string buildTag);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="buildNumber"></param>
    void UpdateBuildNumber(string buildNumber);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    void UploadLog(string path);
}