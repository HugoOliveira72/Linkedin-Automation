using Linkedin_Automation.Model;
using playwright.Model;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Linkedin_Automation.Credencials
{
    public class Credencials
    {
        // Diretorio de execução
        // linkedin_Automation\playwright\bin\Debug\net{version}"
        private static string USERPATH = "../../../../Forms/Files/";
        private FormObject formAttribute;

        public User User { get; set; }

        public Credencials(FormObject formObject)
        {
            this.formAttribute = formObject;

            // LER DADOS DOS USUARIOS
            /// Utiliza enconding diferente para ler caracteres especiais, Windows 1252
            /// Registra o provedor de código de página
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding windows_1252 = Encoding.GetEncoding(1252);

            List<string> userLines = new List<string>();

            //CHECKBOX MARCADA, PEGA DADOS DE USUÁRIO DO FORMULÁRIO
            if (formObject.CheckboxWriteCredentials)
            {
                ///Verificação da existencia do arquivo credencials.txt
                if (!File.Exists(USERPATH))
                {
                    ///Criação de arquivo / Adiciona dados de usuário ao arquivo
                    createCredencialsFile();
                    appendCrencials(this.formAttribute.TxtboxUser, this.formAttribute.TxtboxPassword);
                }
                else
                {
                    ///Adiciona dados de usuário ao arquivo
                    appendCrencials(this.formAttribute.TxtboxUser, this.formAttribute.TxtboxPassword);
                }
            }
            //CHECKBOX DESMARCADA, PEGA DADOS DE USUÁRIO DO ARQUIVO
            else
            {
                // LEITURA CREDENCIALS.TXT
                using (StreamReader sr = new StreamReader(USERPATH, windows_1252))
                {
                    /// Leitura arquivo linha a linha
                    string userLine;
                    while ((userLine = sr.ReadLine()) != null)
                    {
                        userLines.Add(userLine);
                    }
                }

                //VERIFICAR SE ARQUIVO ESTÁ PREENCHIDO
                if (userLines.Count > 0) ///Preenchido
                {
                    ///Atribuir email e senha a this.user
                    User user = new User(userLines[0], userLines[1]);
                    this.User = user;
                }
                else ///Não preenchido
                {
                    ///Exibir mensagem de erro
                    string message = "Não foi possível encontrar as credenciais!";
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    throw new Exception(message);
                }
            }
        }
        private void createCredencialsFile()
        {
            MessageBox.Show("Criando arquivo userInfo.txt", "Criando", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            ///Cria arquivo e escreve dados do usuário ao credencials.txt
            File.Create(USERPATH);
        }

        private void appendCrencials(string userEmail, string password)
        {
            MessageBox.Show("Adicionando credencials em userInfo.txt", "Escrevendo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            string[] lines = [userEmail, password];
            File.AppendAllLines(Path.Combine(USERPATH), lines);
        }
    }

}
