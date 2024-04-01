using forms.Model;

namespace forms.Forms
{
    public partial class ConfigScreen : Form
    {
        public ScreenConfiguration screenConfiguration { get; set; }
        public ConfigScreen()
        {
            InitializeComponent();
        }

        private void comboBox_resolution_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_resolution_type.Text == "Modo janela")
            {
                comboBox_resolution.Enabled = true;
            }
        }

        private void button_apply_configs_Click(object sender, EventArgs e)
        {
            this.screenConfiguration = new ScreenConfiguration(this.comboBox_resolution_type.Text, this.comboBox_resolution.Text);
            this.Close();
        }
    }
}
