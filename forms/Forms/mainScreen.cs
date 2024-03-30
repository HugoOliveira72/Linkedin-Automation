using forms.Forms;
using playwright.Model;

namespace forms
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {

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
                checkedListBox_experience_level.CheckedItems,
                checkedListBox_type_job.CheckedItems,
                checkedListBox_remote.CheckedItems

            );
            //await Script.Main(form);
            RunningScreen runningScreen = new RunningScreen(form);
            runningScreen.Show();
        }
    }
}
