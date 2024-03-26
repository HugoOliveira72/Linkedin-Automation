namespace Linkedin_Automation.Utilities
{
    public class LogUtilities
    {
        private string logpath;
        public LogUtilities()
        {
            this.logpath = Script.LOGPATH;
        }
        public void createLogFile()
        {
            File.WriteAllText(this.logpath, $"============================\nExec: {DateTime.Now}");
        }

        public void writeError(string text)
        {
            File.AppendAllText(this.logpath, Environment.NewLine + text);
        }
    }
}
