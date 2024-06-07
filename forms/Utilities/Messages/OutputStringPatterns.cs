namespace forms.Utilities.Messages
{
    public class OutputStringPatterns
    {

        public string ShowFinalResult(int appliedJobs, int savedJobs, string finishCondition = "")
        {
            string resultText = !string.IsNullOrEmpty(finishCondition) ? finishCondition : "";

            resultText += linePattern();
            resultText += "RESULTADOS\n- VAGAS APLICADAS: ";
            resultText += appliedJobs;
            resultText += "\n- VAGAS SALVAS: ";
            resultText += savedJobs;
            return resultText;
        }

        public string errorPattern(string errorMessage, Exception? errorDescription = null, bool finishMessage = false)
        {
            string logText = $"{errorMessage}: {errorDescription}";
            if (finishMessage)
            {
                logText += "\nFinalizando...";
            }
            return logText;
        }

        public string startPattern()
        {
            DateTime dateTime = DateTime.Now;
            return $"\n=============================\t {dateTime}";
        }

        public string linePattern()
        {
            return "\n=============================\n";
        }
    }
}
