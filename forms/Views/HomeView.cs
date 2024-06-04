using forms.Model;
using forms.Views.Interfaces;
using static System.Windows.Forms.CheckedListBox;

namespace forms
{
    public partial class HomeView : Form, IHomeView
    {
        public ConfigurationModel screenConfiguration;

        public event EventHandler ShowConfigView;
        public event EventHandler ShowAutomationView;

        //Fields
        public string Job
        {
            get { return txtbox_job.Text; }
            set { txtbox_job.Text = value; }
        }
        public string amountJobs
        {
            get { return amount_jobs.Text; }
            set { amount_jobs.Text = value; }
        }
        public string ComboBoxClassifyBy
        {
            get { return comboBox_choose_by.Text; }
            set { comboBox_choose_by.Text = value; }
        }
        public string comboBoxAnnoucementDate
        {
            get { return comboBox_annoucement_date.Text; }
            set { comboBox_annoucement_date.Text = value; }
        }
        public CheckedItemCollection checkedListBoxExperienceLevel
        {
            get { return checkedListBox_experience_level.CheckedItems; }
        }
        public CheckedItemCollection checkedListBoxTypeJob
        {
            get { return checkedListBox_type_job.CheckedItems; }
        }
        public CheckedItemCollection checkedListBoxRemote
        {
            get { return checkedListBox_remote.CheckedItems; }
        }

        //Constructor
        public HomeView()
        {
            InitializeComponent();
        }

        private void button_config_Click(object sender, EventArgs e)
        {
            ShowConfigView?.Invoke(this, EventArgs.Empty);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ShowAutomationView?.Invoke(this, EventArgs.Empty);
        }
    }
}
