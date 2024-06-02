using forms.Forms;
using forms.Model;
using forms.Models.Interfaces;
using forms.Presenters;
using forms.Repositories;
using forms.Views.Interfaces;
using playwright.Model;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.CheckedListBox;

namespace forms
{
    public partial class HomeView : Form, IHomeView
    {
        public ConfigurationModel screenConfiguration;
        private string userName;
        private string password;
        private bool rememberMe;

        public event EventHandler ShowConfigView;
        public event EventHandler ShowRunningView;

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

        //public HomeView()
        //{
        //    InitializeComponent();
        //    AssociateAndRaiseViewEvents();
        //}

        //Constructor
        public HomeView(string txtUserName, string txtPassword, bool rememberMe)
        {
            this.userName = txtUserName;
            this.password = txtPassword;
            this.rememberMe = rememberMe;
            InitializeComponent();
            //AssociateAndRaiseViewEvents();
        }

        //private void AssociateAndRaiseViewEvents()
        //{
        //    button_config.Click += delegate { ShowConfigView?.Invoke(this, EventArgs.Empty); };
        //    send_button.Click += delegate { ShowRunningView?.Invoke(this, EventArgs.Empty); };
        //}


        private void button_config_Click(object sender, EventArgs e)
        {
            ShowConfigView?.Invoke(this, EventArgs.Empty);
        }
    }
}
