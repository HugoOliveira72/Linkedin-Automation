using forms.Models.Interfaces;
using forms.Utilities.Messages;

namespace forms.Presenters.Services
{
    public class LogService : ILogService
    {
        private OutputStringPatterns outputStringPatterns = new OutputStringPatterns();
        private ILogRepository _logRepository;
        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public void LogFileExistingVerification()
        {
            string logPath = _logRepository.GetFilePath();
            if (!File.Exists(logPath))
                _logRepository.CreateTextFile(logPath);
            else
                _logRepository.AppendTextFile(logPath, outputStringPatterns.dateLinePattern());
        }
    }
}
