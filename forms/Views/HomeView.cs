using forms.Model;
using forms.Models.Filters;
using forms.Models.Interfaces;
using forms.Presenters;
using forms.Presenters.Controls;
using forms.Repositories;
using forms.Services;
using forms.Views;
using forms.Views.Interfaces;
using forms.Views.Interfaces.Control;
using forms.Views.UserControls;
using Krypton.Toolkit;

namespace forms
{
    public partial class HomeView : Form, IHomeView
    {
        public ConfigurationModel screenConfiguration;
        public IDataService<dynamic> _dataService;
        private IFilterControlView filterControlView;
        private ErrorProvider errorProvider = new ErrorProvider();

        //Attributes
        public string Job
        {
            get { return txtBox_job.Text; }
            set { txtBox_job.Text = value; }
        }
        public string AmountJobs
        {
            get { return amount_jobs.Text; }
            set { amount_jobs.Text = value; }
        }

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

        //Events
        public event EventHandler StartAutomation;
        public event EventHandler StopAutomation;
        public event EventHandler LogFileEvent;
        public event EventHandler StoreFilters;

        //Constructor
        public HomeView(IDataService<dynamic> dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }

        #region Tabs

        private void kryptonButtonHome_Click(object sender, EventArgs e)
        {
            MainControlView mainView = new MainControlView();
            addUserControl(mainView);
        }
        private void kryptonButtonFilter_Click(object sender, EventArgs e)
        {
            filterControlView = new FilterControlView(this);
            new FilterPresenter(filterControlView, _dataService);
            addUserControl((FilterControlView)filterControlView);
        }
        private void kryptonButtonSettings_Click(object sender, EventArgs e)
        {
            IConfigControlView configControlView = new ConfigControlView();
            IConfigRepository configRepository = new ConfigRepository();
            new ConfigPresenter(configControlView, configRepository);
            addUserControl((UserControl)configControlView);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            panelContainer.BringToFront();
        }
        #endregion

        #region Validations

        private void TxtBox_job_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            ValidateTextBox(txtBox_job, "Por favor, insira o cargo/vaga", eventArgs);
        }

        private void Amount_jobs_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            ValidateTextBox(amount_jobs, "Por favor, insira a quantidade de vagas", eventArgs);
        }

        private void ValidateTextBox(KryptonTextBox textBox, string message, System.ComponentModel.CancelEventArgs cancelEventArgs)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                cancelEventArgs.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, message);
            }
            else
            {
                cancelEventArgs.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        #endregion

        private void startButton_Click(object sender, EventArgs e)
        {
            StartAutomation?.Invoke(this, EventArgs.Empty);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StoreFilters?.Invoke(this, EventArgs.Empty);
        }

        //public async void AutomationView_Shown(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Tela carregada", "Aviso", MessageBoxButtons.OK);

        //    FilterFieldsModel HomeData = _dataService.GetData();
        //    txtBox_saved_jobs.Text = "0";
        //    txtBox_applied_Jobs.Text = $"0/{HomeData.AmountOfJobs}";
        //    txtBox_job.Text = HomeData.TxtboxJob;

        //    StartAutomation?.Invoke(this, EventArgs.Empty);
        //}

    }
}
