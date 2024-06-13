namespace forms.Utilities.Messages
{
    public class OutputStringPatterns
    {

        public string ShowFinalResult(int appliedJobs, int savedJobs)
        {
            string resultText = "";
            resultText += linePattern();
            resultText += "RESULTADOS\n- VAGAS APLICADAS: ";
            resultText += appliedJobs;
            resultText += "\n- VAGAS SALVAS: ";
            resultText += savedJobs;
            return resultText;
        }

        public string errorPattern(string errorMessage, Exception? errorDescription = null)
        {
            return $"{errorMessage}: {errorDescription}";
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
