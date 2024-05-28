using forms.Model;
using forms.Utilities.Messages;

namespace forms.Forms
{
    public partial class ConfigScreen : Form
    {
        public ScreenConfiguration screenConfiguration = new ScreenConfiguration();
        private static string RESPATH = "../../../../Forms/Config/resolution.txt";

        public ConfigScreen()
        {
            InitializeComponent();
            this.Shown += new EventHandler(ConfigScreen_Shown);
        }

        public void ConfigScreen_Shown(object sender, EventArgs e)
        {
            // Define o primeiro item (índice 0) como selecionado no comboBox_resolution_type, Tela cheia
            comboBox_resolution_type.SelectedIndex = 0;

            // Verifica se o arquivo especificado existe
            if (!File.Exists(RESPATH)) // Quando o arquivo Resolution não existe
            {
                // Cria um novo arquivo e escreve "Tela cheia" nele
                // O método WriteAllText cria um novo arquivo, escreve a string especificada e fecha o arquivo
                File.WriteAllText(RESPATH, "Tela cheia");
            }
            else // Quando o arquivo Resolution existe
            {
                // Lê todas as linhas do arquivo especificado e as armazena em uma lista
                var lines = File.ReadLines(RESPATH).ToList();

                // Atribui o primeiro item da lista (que é a primeira linha do arquivo) ao Text do comboBox_resolution_type
                this.comboBox_resolution_type.Text = lines.FirstOrDefault();

                // Atribui o último item da lista (que é a última linha do arquivo) ao Text do comboBox_resolution
                this.comboBox_resolution.Text = lines.LastOrDefault();
            }

        }

        private void comboBox_resolution_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_resolution.Enabled = (comboBox_resolution_type.Text == "Tela cheia") ? false : true;
        }

        private void button_save_configs_Click(object sender, EventArgs e)
        {
            // Cria uma nova configuração de tela com os valores selecionados nos ComboBoxes
            this.screenConfiguration = new ScreenConfiguration(this.comboBox_resolution_type.Text, this.comboBox_resolution.Text);

            // Abre o arquivo especificado para gravação
            using (StreamWriter sw = new StreamWriter(RESPATH, false))
            {
                // Escreve os valores de ScreenType e Resolution da configuração de tela no arquivo
                sw.WriteLine(this.screenConfiguration.ScreenType);
                sw.WriteLine(this.screenConfiguration.Resolution);
            }

            // Exibe uma caixa de mensagem informando que as configurações foram aplicadas com sucesso
            MessageBox.Show("CONFIGURAÇÕES APLICADAS COM SUCESSO!", "SUCESSO");

            // Fecha o formulário
            this.Close();
        }
    }
}
