using forms.Models.Interfaces;
using forms.Utilities.Messages;

namespace forms.Repositories
{
    public class LogRepository : BaseRepository, ILogRepository
    {
        
        private OutputStringPatterns outputStringPatterns = new OutputStringPatterns();
        private const string LogDirectoryXpath = "/config/logDirectoryPath";

        public LogRepository()
        {
        }

        public void WriteStartMessage()
        {
            File.AppendAllText(GetFilePath(), Environment.NewLine + outputStringPatterns.dateLinePattern());
        }

        public void WriteALogError(string message, Exception exception)
        {
            string? logText = outputStringPatterns.errorPattern(message, exception);
            AppendTextFile(GetFilePath(), logText);
        }

        public void WriteALogError(Exception exception)
        {
            string? logText = outputStringPatterns.errorPattern(exception);
            AppendTextFile(GetFilePath(), logText);
        }

        public string GetFilePath()
        {
            return GetFilePath(LogDirectoryXpath);
        }
    }
}
