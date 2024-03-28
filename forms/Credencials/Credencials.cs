using forms.Utilities.Messages;
using Linkedin_Automation.Model;
using playwright.Model;
using System.Text;

namespace Linkedin_Automation.Credencials
{
    public class Credencials
    {
        // Diretorio de execução
        // linkedin_Automation\playwright\bin\Debug\net{version}"
        private static string USERPATH = "../../../../Forms/Files/userinfo.txt";
        private FormObject formAttribute;

        public User User { get; set; }

        public Credencials(FormObject formObject)
        {
            this.formAttribute = formObject;

            StringPatterns stringPatterns = new StringPatterns();

            // LER DADOS DOS USUARIOS
            /// Utiliza enconding diferente para ler caracteres especiais, Windows 1252
            /// Registra o provedor de código de página
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding windows_1252 = Encoding.GetEncoding(1252);

            List<string> userLines = new List<string>();

            if (!File.Exists(USERPATH))
            {
                ///Criação de arquivo / Adiciona dados de usuário ao arquivo
                createCredencialsFile();
            }

            // LEITURA CREDENCIALS.TXT
            try
            {
                using (StreamReader sr = new StreamReader(USERPATH, windows_1252))
                {
                    /// Leitura arquivo linha a linha
                    string userLine;
                    while ((userLine = sr.ReadLine()) != null)
                    {
                        userLines.Add(userLine);
                    }
                }
            }
            catch (Exception exception)
            {
                stringPatterns.errorPattern(exception.Message, exception);
            }
            
            //VERIFICAR SE ARQUIVO ESTÁ PREENCHIDO
            if (userLines.Count > 0) ///Preenchido
            {
                ///Atribuir email e senha a this.user, pegar dados do arquivo
                User user = new User(userLines[0], userLines[1]);
                this.User = user;
            }
            else ///Não preenchido
            {
                //CHECKBOX MARCADA, PEGA DADOS DE USUÁRIO DO FORMULÁRIO
                if (formObject.CheckboxWriteCredentials)
                {
                    ///Verificação da existencia do arquivo credencials.txt
                    appendCrencials(this.formAttribute.TxtboxUser, this.formAttribute.TxtboxPassword);
                    return;
                }

                ///Exibir mensagem de erro
                string message = stringPatterns.errorPattern("Não foi possível encontrar as credenciais!");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                throw new Exception(message);
            }

        }
        private void createCredencialsFile()
        {
            MessageBox.Show("Criado arquivo userInfo.txt", "Criando", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            ///Cria arquivo
            File.Create(USERPATH);
        }

        private void appendCrencials(string userEmail, string password)
        {
            MessageBox.Show("Adicionado credencials em userInfo.txt", "Escrevendo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            string[] lines = [userEmail, password];
            File.AppendAllLines(Path.Combine(USERPATH), lines);
        }
    }

}
