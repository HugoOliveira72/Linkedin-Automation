using forms.Model;
using playwright.Model;
using System.Threading;

namespace forms.Forms
{
    public partial class ConfigScreen : Form
    {
        public ScreenConfiguration screenConfiguration { get; set; }
        public ConfigScreen()
        {
            InitializeComponent();

            this.Shown += new EventHandler(ConfigScreen_Shown);
        }

        public void ConfigScreen_Shown(object sender, EventArgs e)
        {
            comboBox_resolution_type.SelectedIndex = 0;
        }

        private void comboBox_resolution_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_resolution.Enabled = (comboBox_resolution_type.Text == "Tela cheia") ? false : true;
        }

        private void button_apply_configs_Click(object sender, EventArgs e)
        {
            this.screenConfiguration = new ScreenConfiguration(this.comboBox_resolution_type.Text, this.comboBox_resolution.Text);
            this.Close();
        }
    }
}
