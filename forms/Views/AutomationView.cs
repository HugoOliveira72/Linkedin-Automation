using forms.Models.Filters;
using forms.Services;
using forms.Views.Interfaces;

namespace forms.Forms
{
    public partial class AutomationView : Form, IHomeView
    {
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();
        private IDataService<dynamic> _dataService;

        //Properties
        public string? CurrentJob
        {
            get { return txtBox_job.Text; }
            set { txtBox_job.Text = value; }
        }
        public int AmountOfAppliedJobs
        {
            get { return Int32.Parse(txtBox_applied_Jobs.Text); }
            set { txtBox_applied_Jobs.Text = value.ToString(); }
        }
        public int AmountOfSavedJobs
        {
            get { return Int32.Parse(txtBox_saved_jobs.Text); }
            set { txtBox_saved_jobs.Text = value.ToString(); }
        }
        public string? RichtxtBox
        {
            get { return richtxtBox.Text; }
            set { richtxtBox.Text = value; }
        }

        public bool ButtonEnabled 
        {
            get { return button_exit.Enabled; }
            set { button_exit.Enabled = value; }
        }

        //Events
        public event EventHandler StartAutomation;
        public event EventHandler LogFileEvent;
        public event EventHandler StopAutomation;
        public event EventHandler StoreFilters;

        public AutomationView(IDataService<dynamic> dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            this.Shown += new EventHandler(AutomationView_Shown);
        }

        public async void AutomationView_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Tela carregada", "Aviso", MessageBoxButtons.OK);

            FilterFieldsModel HomeData = _dataService.GetData();
            txtBox_saved_jobs.Text = "0";
            txtBox_applied_Jobs.Text = $"0/{HomeData.AmountOfJobs}";
            txtBox_job.Text = HomeData.TxtboxJob;

            StartAutomation?.Invoke(this,EventArgs.Empty);
        }

        private void stopApplication_button_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
            this.Close();
        }

    }
}
