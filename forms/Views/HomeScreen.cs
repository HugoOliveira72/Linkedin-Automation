using forms.Forms;
using forms.Model;
using forms.Models.Interfaces;
using forms.Presenters;
using forms.Repositories;
using forms.Views.Interfaces;
using playwright.Model;

namespace forms
{
    public partial class HomeScreen : Form
    {

        public ConfigurationModel screenConfiguration;
        private string userName;
        private string password;

        public HomeScreen(string txtUserName, string txtPassword)
        {
            this.userName = txtUserName;
            this.password = txtPassword;
            InitializeComponent();
        }
        private async void sendButton_Click(object sender, EventArgs e)
        {
            FormObject form = new FormObject(
                this.userName,
                this.password,
            checkbox_write_credentials_in_file.Checked,
                txtbox_job.Text,
                Int32.Parse(amount_jobs.Text),
                comboBox_choose_by.Text,
                comboBox_annoucement_date.Text,
                checkedListBox_experience_level.CheckedItems,
                checkedListBox_type_job.CheckedItems,
                checkedListBox_remote.CheckedItems,
                this.screenConfiguration
            );
            AutomationScreen runningScreen = new AutomationScreen(form);
            runningScreen.Show();
        }

        private void button_config_Click(object sender, EventArgs e)
        {
            IConfigView view = new ConfigView();
            IConfigRepository configRepository = new ConfigRepository();
            new ConfigPresenter(view, configRepository);
        }
    }
}
