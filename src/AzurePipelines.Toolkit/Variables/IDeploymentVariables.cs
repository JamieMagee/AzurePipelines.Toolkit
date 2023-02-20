namespace AzurePipelines.Toolkit.Variables;

/// <summary>
///     These variables are scoped to a specific Deployment job and will be resolved only at job execution time.
/// </summary>
public interface IDeploymentVariables
{
    /// <summary>
    ///     Name of the environment targeted in the deployment job to run the deployment steps and record the deployment
    ///     history.
    ///     <example>
    ///         <code>smarthotel-dev</code>
    ///     </example>
    /// </summary>
    string? EnvironmentName { get; }

    /// <summary>
    ///     ID of the environment targeted in the deployment job.
    ///     <example>10</example>
    /// </summary>
    string? EnvironmentId { get; }

    /// <summary>
    ///     Name of the specific resource within the environment targeted in the deployment job to run the deployment steps and
    ///     record the deployment history.
    ///     <example>
    ///         <code>bookings</code>
    ///     </example>
    /// </summary>
    string? EnvironmentResourceName { get; }

    /// <summary>
    ///     ID of the specific resource within the environment targeted in the deployment job to run the deployment steps.
    ///     <example>
    ///         <code>4</code>
    ///     </example>
    /// </summary>
    string? EnvironmentResourceId { get; }

    /// <summary>
    ///     The name of the deployment strategy.
    /// </summary>
    string? StrategyName { get; }

    /// <summary>
    ///     The current cycle name in a deployment.
    /// </summary>
    string? StrategyCycleName { get; }
}