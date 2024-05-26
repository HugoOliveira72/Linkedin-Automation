using forms.Forms;
using forms.Model;
using playwright.Model;

namespace forms
{
    public partial class HomeScreen : Form
    {
        public ScreenConfiguration screenConfiguration;
        public HomeScreen()
        {
            InitializeComponent();
        }
        private async void sendButton_Click(object sender, EventArgs e)
        {
            FormObject form = new FormObject(
                txtbox_user.Text,
                txtbox_password.Text,
                checkbox_write_credentials_in_file.Checked,
                txtbox_job.Text,
                Int32.Parse(amount_jobs.Text),
                comboBox_choose_by.Text,
                comboBox_annoucement_date.Text,
                checkedListBox_experience_level.CheckedItems,
                checkedListBox_type_job.CheckedItems,
                checkedListBox_remote.CheckedItems,
                this.screenConfiguration
            ) ;
            AutomationScreen runningScreen = new AutomationScreen(form);
            runningScreen.Show();
        }

        private void button_config_Click(object sender, EventArgs e)
        {
            ConfigScreen configScreen = new ConfigScreen();
            configScreen.ShowDialog();

            this.screenConfiguration = configScreen.screenConfiguration;
        }
    }
}
