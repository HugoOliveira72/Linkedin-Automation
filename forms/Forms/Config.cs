using forms.Model;
using forms.Utilities.Messages;

namespace forms.Forms
{
    public partial class ConfigScreen : Form
    {
        public ScreenConfiguration screenConfiguration = new ScreenConfiguration();
        private static string RESPATH = "../../../../Forms/Config/resolution.txt";
        private StringPatterns stringPatterns = new StringPatterns();

        public ConfigScreen()
        {
            InitializeComponent();
            this.Shown += new EventHandler(ConfigScreen_Shown);
        }

        public void ConfigScreen_Shown(object sender, EventArgs e)
        {
            comboBox_resolution_type.SelectedIndex = 0;

            if (!File.Exists(RESPATH)) //Quando Arquivo Resolution não existe
            {
                ///Criação de arquivo / Escrever
                using (StreamWriter sw = new StreamWriter(RESPATH, false))
                {
                    ///Adicionando resolução tela cheia como padrão
                    sw.WriteLine("Tela cheia");
                }
            }
            else //Quando resolution existe
            {
                List<string> lines = new List<string>();
                using (StreamReader sr = new StreamReader(RESPATH))
                {
                    /// Leitura arquivo linha a linha
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                ///Atribuir aos elementos
                this.comboBox_resolution_type.Text = lines.FirstOrDefault();
                this.comboBox_resolution.Text = lines.LastOrDefault();
            }
        }

        private void comboBox_resolution_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_resolution.Enabled = (comboBox_resolution_type.Text == "Tela cheia") ? false : true;
        }

        private void button_save_configs_Click(object sender, EventArgs e)
        {
            this.screenConfiguration = new ScreenConfiguration(this.comboBox_resolution_type.Text, this.comboBox_resolution.Text);

            //ESCREVER CONFIGURAÇÕES NO ARQUIVO EXISTENTE
            using (StreamWriter sw = new StreamWriter(RESPATH, false))
            {
                sw.WriteLine(this.screenConfiguration.ScreenType);
                sw.WriteLine(this.screenConfiguration.Resolution);
            }
            MessageBox.Show("CONFIGURAÇÕES APLICADAS COM SUCESSO!", "SUCESSO");
            this.Close();
        }
    }
}
