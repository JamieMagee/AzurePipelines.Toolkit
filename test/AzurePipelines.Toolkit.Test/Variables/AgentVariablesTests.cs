namespace AzurePipelines.Toolkit.Test.Variables;

using AzurePipelines.Toolkit.Models;
using FluentAssertions;
using Xunit;

public class AgentVariablesTests
{
    private readonly IAzurePipelinesToolkit toolkit;

    public AgentVariablesTests()
    {
        this.toolkit = new AzurePipelinesToolkit();
    }

    [Fact]
    public void JobStatus()
    {
        Environment.SetEnvironmentVariable("AGENT_JOBSTATUS", "Succeeded");

        var jobStatus = this.toolkit.Variables.Agent.JobStatus;

        jobStatus.Should().Be(AgentJobStatus.Succeeded);
    }
}
