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
            // Armazena o objeto FormObject recebido como atributo da classe
            this.formAttribute = formObject;

            // Verifica se o arquivo de credenciais existe
            if (!File.Exists(USERPATH))
            {
                // Se o arquivo não existe, cria um novo arquivo e adiciona os dados do usuário
                createCredencialsFile();
            }

            // Lê as linhas do arquivo de credenciais
            List<string> userLines = File.ReadAllLines(USERPATH, Encoding.UTF8).ToList();

            // Verifica se o arquivo está preenchido
            if (userLines.Count > 0)
            {
                // Se o arquivo contém dados, cria um objeto User com o email e senha lidos do arquivo
                this.User = new User(userLines[0], userLines[1]);
            }
            else
            {
                // Se o arquivo está vazio, verifica se a checkbox está marcada no formulário
                if (formObject.CheckboxWriteCredentials)
                {
                    // Se a checkbox está marcada, adiciona as credenciais do formulário ao arquivo
                    appendCredentials(this.formAttribute.TxtboxUser, this.formAttribute.TxtboxPassword);
                    return;
                }

                // Se a checkbox não está marcada e o arquivo está vazio, exibe uma mensagem de erro
                string message = "Não foi possível encontrar as credenciais!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                throw new Exception(message);
            }
        }

        private void createCredencialsFile()
        {
            // Cria um novo arquivo de credenciais
            MessageBox.Show("Criado arquivo userInfo.txt", "Criando", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            File.Create(USERPATH).Dispose(); // Dispose() para liberar recursos
        }

        private void appendCredentials(string userEmail, string password)
        {
            // Adiciona as credenciais do usuário ao arquivo de credenciais
            MessageBox.Show("Adicionado credenciais em userInfo.txt", "Escrevendo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            string[] lines = { userEmail, password };
            File.AppendAllLines(USERPATH, lines);
        }

    }

}
