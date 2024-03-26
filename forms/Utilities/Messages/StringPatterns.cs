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
            string linesPattern = "===============================\n\t!ERROR!\n===============================\n";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(linesPattern);

            Thread.Sleep(TimeSpan.FromSeconds(0.5));
            Console.WriteLine($"{errorMessage}: ");

            Console.ResetColor(); // Resetar a cor para o padrão
            Console.Write(errorDescription);

            if (finishMessage)
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
                Console.WriteLine("\nPressione qualquer tecla para finalizar... ");
            }

            string logText = linesPattern;
            logText += $"{errorMessage}: {errorDescription}";
            return logText;
        }

    }
}
