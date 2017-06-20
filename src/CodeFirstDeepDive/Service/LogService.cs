using Microsoft.Extensions.Logging;

namespace CodeFirstDeepDive.Service
{
    public class LogService:ILogService
    {
        private readonly ILogger<LogService> _logger;

        public LogService(ILogger<LogService> logger)
        {
            _logger = logger;
        }

        public void LogInfoMessages(string message)
        {
            _logger.LogInformation(message);
        }
    }
    
}