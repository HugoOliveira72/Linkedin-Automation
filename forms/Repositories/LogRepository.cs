using forms.Models.Interfaces;
using forms.Utilities.Messages;
using System.Xml;

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
            File.AppendAllText(GetFilePath(), Environment.NewLine + outputStringPatterns.startPattern());
        }

        public void WriteALogError(string message, Exception exception)
        {
            string? logText = outputStringPatterns.errorPattern(message, exception);
            UpdateTextFile(GetFilePath(), logText);
        }

        public void WriteALogError(Exception exception)
        {
            string? logText = outputStringPatterns.errorPattern(exception);
            UpdateTextFile(GetFilePath(), logText);
        }

        public string GetFilePath()
        {
            return GetFilePath(LogDirectoryXpath);
        }
    }
}
