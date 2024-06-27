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
using static System.Windows.Forms.CheckedListBox;

namespace forms
{
    public partial class HomeView : Form, IHomeView
    {
        public ConfigurationModel screenConfiguration;
        public IDataService<dynamic> _dataService;

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

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            panelContainer.BringToFront();
        }

        //Tabs
        private void kryptonButtonHome_Click(object sender, EventArgs e)
        {
            MainControlView mainView = new MainControlView();
            addUserControl(mainView);
        }

        private void kryptonButtonFilter_Click(object sender, EventArgs e)
        {
            IFilterControlView filterControlView = new FilterControlView();
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

        //Actions 
        private void startButton_Click(object sender, EventArgs e)
        {
            
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
