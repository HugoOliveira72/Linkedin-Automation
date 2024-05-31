using forms.Forms;
using forms.Utilities.Messages;

namespace Linkedin_Automation.Utilities
{
    public class LogUtilities
    {
        private string logpath;
        private StringPatterns stringPatterns = new StringPatterns();

        public LogUtilities()
        {
            this.logpath = AutomationScreen.LOGPATH;
        }
        public void createLogFile()
        {
            File.WriteAllText(this.logpath, "");
        }

        public void writeStartMessage()
        {
            File.AppendAllText(this.logpath, Environment.NewLine + stringPatterns.startPattern());
        }

        private void writeError(string text)
        {
            File.AppendAllText(this.logpath, Environment.NewLine + text);
        }

        public void LogError(string message, Exception exception)
        {
            var logText = stringPatterns.errorPattern(message, exception, true);
            writeError(logText);
        }


    }
}
