using Linkedin_Automation.Model;
using playwright.Model;
using System.Text;

namespace Linkedin_Automation.Credencials
{
    public class Credencials
    {
        // Diretorio de execução
        // linkedin_Automation\playwright\bin\Debug\net{version}"
        private static string USERPATH = "../../../../playwright/Files/userInfo.txt";

        public User User { get; set; }

        public Credencials(FormObject formObject)
        {
            // LER DADOS DOS USUARIOS
            /// Utiliza enconding diferente para ler caracteres especiais, Windows 1252
            /// Registra o provedor de código de página
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding windows_1252 = Encoding.GetEncoding(1252);

            List<string> userLines = new List<string>();

            //VALIDAR CHECKBOX, PARA CRIAR ARQUIVO TXT
            if (formObject.CheckboxWriteCredentials)
            {
                //VERIFICAÇÃO EXISTENCIA CREDENCIALS.TXT
                if (!File.Exists(USERPATH))
                {
                    var result = "Criando arquivo userInfo.txt";
                    Console.WriteLine(result);
                    ///Cria arquivo e escreve dados do usuário ao credencials.txt
                    using (StreamWriter writer = new StreamWriter(USERPATH))
                    {
                        writer.WriteLine(formObject.TxtboxUser);
                        writer.WriteLine(formObject.TxtboxPassword);
                    }
                }
                else
                {
                    var result = "Arquivo já existe";
                    Console.WriteLine(result);
                }
            }

            // LEITURA CREDENCIALS.TXT
            using (StreamReader sr = new StreamReader(USERPATH, windows_1252))
            {
                /// Ler arquivo linha a linha
                string userLine;
                while ((userLine = sr.ReadLine()) != null)
                {
                    userLines.Add(userLine);
                }
            }

            //VERIFICAR SE ARQUIVO ESTÁ CORRETO
            if (userLines.Count > 0)
            {
                // ATRIBUIR EMAIL,SENHA A VARIAVEIS
                User user = new User(userLines[0], userLines[1]);
                this.User = user;
            }

        }
    }
}
