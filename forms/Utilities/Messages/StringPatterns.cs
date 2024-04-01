namespace forms.Utilities.Messages
{
    public class StringPatterns
    {

        public void finishPattern(int appliedJobs, int savedJobs, string finishCondition = "")
        {
            Console.WriteLine(!string.IsNullOrEmpty(finishCondition) ? finishCondition : "");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===============================");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"RESULTADOS\n- VAGAS APLICADAS: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(appliedJobs);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n- VAGAS SALVAS: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(savedJobs);

            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("\nPressione qualquer tela para finalizar o programa...");
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
