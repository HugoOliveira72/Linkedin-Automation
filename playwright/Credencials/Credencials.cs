using Linkedin_Automation.Model;
using Linkedin_Automation.Utilities;
using playwright.Model;
using System.Text;

namespace Linkedin_Automation.Credencials
{
    public class Credencials
    {
        // Diretorio de exec 
        // Linkedin_Automation\\bin\\Debug\\net6.0"
        private static string USERPATH = "../../../../playwright/Files/userInfo.txt";
        private static StringUtilities stringUtilities = new StringUtilities();

        public User User { get; set; }

        public Credencials(FormObject formObject)
        {
            // LER DADOS DOS USUARIOS
            /// Utiliza enconding diferente para ler caracteres especiais, Windows 1252
            /// Registra o provedor de código de página
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Encoding windows_1252 = Encoding.GetEncoding(1252);

            //ADICIONAR DADOS DO FORMULARIO AO CREDENCIALS.TXT
            if (formObject.CheckboxWriteCredentials)
            {
                ///Criar arquivo userinfo.txt
                //File.WriteAllText(USERPATH, "");

                using (StreamWriter writer = new StreamWriter(USERPATH))
                {
                    writer.WriteLine(formObject.TxtboxUser);
                    writer.WriteLine(formObject.TxtboxPassword);
                }

                //VERIFICAÇÃO EXISTENCIA CREDENCIALS.TXT
                //if (!File.Exists(USERPATH))
                //{
                //    File.WriteAllText(USERPATH, "");
                //    stringUtilities.errorPattern("\nPreencha as credenciais no arquivo 'Files/userInfo.txt'", null, true);
                //    Console.ReadKey();
                //}
            }


            // LEITURA CREDENCIALS.TXT
            List<string> userLines = new List<string>();
            using (StreamReader sr = new StreamReader(USERPATH, windows_1252))
            {
                /// Ler arquivo linha a linha
                string userLine;
                while ((userLine = sr.ReadLine()) != null)
                {
                    userLines.Add(userLine);
                }
            }
            // ATRIBUIR EMAIL,SENHA A VARIAVEIS
            User user = new User(userLines[0], userLines[1]);
            this.User = user;
        }
    }
}
