using forms.Views.Interfaces.Control;
using static Krypton.Toolkit.KryptonCheckedListBox;

namespace forms.Views
{
    public partial class FilterControlView : UserControl, IFilterControlView
    {
        public FilterControlView()
        {
            InitializeComponent();
        }

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

        //Events
        public event EventHandler HandleFilter;


        private void Txtbox_job_TrackMouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void Amount_jobs_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void ComboBox_choose_by_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            handleAndRaiseEvents();
        }

        private void ComboBox_annoucement_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void CheckedListBox_experience_level_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void CheckedListBox_type_job_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void CheckedListBox_remote_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void handleAndRaiseEvents()
        {
            HandleFilter?.Invoke(this, EventArgs.Empty);
        }
    }
}
