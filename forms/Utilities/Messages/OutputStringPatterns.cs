﻿namespace forms.Utilities.Messages
{
    public class OutputStringPatterns
    {

        public string ShowFinalResult(int appliedJobs, int savedJobs)
        {
            string resultText = "";
            resultText += linePattern();
            resultText += "\n- VAGAS APLICADAS: ";
            resultText += appliedJobs;
            resultText += "\n- VAGAS SALVAS: ";
            resultText += savedJobs;
            return resultText;
        }

        public string errorPattern(string errorMessage, Exception? errorDescription = null)
        {
            return $"{errorMessage}: {errorDescription}";
        }

        public string errorPattern(Exception? errorDescription = null)
        {
            return $"Error: {errorDescription}";
        }

        public string dateLinePattern()
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
