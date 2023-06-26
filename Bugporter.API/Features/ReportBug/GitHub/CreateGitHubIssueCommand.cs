using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Bugporter.API.Features.ReportBug.GitHub
{
    public class CreateGitHubIssueCommand
    {
        private readonly ILogger<CreateGitHubIssueCommand> _logger;

        public CreateGitHubIssueCommand(ILogger<CreateGitHubIssueCommand> logger)
        {
            _logger = logger;
        }

        public async Task<ReportedBug> Execute(NewBug newBug)
        {
            _logger.LogInformation("Creating GitHub issue");

            // Create GitHub issue
            ReportedBug reportedBug = new ReportedBug("1", newBug.Summary, newBug.Description);

            _logger.LogInformation("Succesfully created GitHub issue {Id}", reportedBug.Id);

            return reportedBug;
        }
    }
}
