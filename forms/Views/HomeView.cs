using forms.Models.Filters;
using forms.Models.Interfaces;
using forms.Presenters;
using forms.Presenters.Controls;
using forms.Repositories;
using forms.Services;
using forms.Utilities.Messages;
using forms.Views;
using forms.Views.Interfaces;
using forms.Views.Interfaces.Control;
using forms.Views.UserControls;
using Krypton.Toolkit;
using System.ComponentModel;

namespace forms
{
    public partial class HomeView : Form, IHomeView
    {
        private IDataService<dynamic> _dataService;
        private IFilterControlView filterControlView;
        private ErrorProvider errorProvider = new();
        private OutputStringPatterns stringPatterns = new();

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
            get { return txtBoxCurrentJob.Text; }
            set { txtBoxCurrentJob.Text = value; }
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
            get { return consoleRichTxtBox.Text; }
            set { consoleRichTxtBox.Text = value; }
        }
        public bool ButtonStopEnabled
        {
            get { return stopButton.Enabled; }
            set { stopButton.Enabled = value; }
        }

        public bool ButtonPlayEnabled
        {
            get { return playButton.Enabled; }
            set { playButton.Enabled = value; }
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
            this.Load += kryptonButtonHome_Click;
        }

        #region Tabs

        private void kryptonButtonHome_Click(object sender, EventArgs e)
        {
            MainControlView mainView = new MainControlView();
            addUserControl(mainView);

            //Desativar botão, para não haver mais HOUVER depois de clicado
            kryptonButtonHome.Enabled = false;
            //Ativar outros botões
            kryptonButtonFilter.Enabled = true;  ///Filter
            kryptonButtonSettings.Enabled = true;///Settings

        }
        private void kryptonButtonFilter_Click(object sender, EventArgs e)
        {
            FilterFieldsModel filterFieldsModel = _dataService.GetData();
            filterControlView = new FilterControlView(filterFieldsModel);
            new FilterPresenter(filterControlView, _dataService);
            addUserControl((FilterControlView)filterControlView);

            //Desativar botão, para não haver mais HOUVER depois de clicado
            kryptonButtonFilter.Enabled = false;
            //Ativar outros botões
            kryptonButtonHome.Enabled = true;    ///Home
            kryptonButtonSettings.Enabled = true;///Settings
        }
        private void kryptonButtonSettings_Click(object sender, EventArgs e)
        {
            IConfigControlView configControlView = new ConfigControlView();
            IConfigRepository configRepository = new ConfigRepository();
            new ConfigPresenter(configControlView, configRepository);
            addUserControl((UserControl)configControlView);

            //Desativar botão, para não haver mais HOUVER depois de clicado
            kryptonButtonSettings.Enabled = false;
            //Ativar outros botões
            kryptonButtonHome.Enabled = true;   ///Home
            kryptonButtonFilter.Enabled = true; ///Filter
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

        private void TxtBox_job_Validating(object sender, CancelEventArgs eventArgs)
        {
            //Verifica se campo está vazio
            ValidateTextBox(txtBox_job, "Por favor, insira o cargo/vaga", eventArgs);
        }

        private void Amount_jobs_Validating(object sender, CancelEventArgs eventArgs)
        {
            //Verifica se campo está vazio
            if(!ValidateTextBox(amount_jobs, "Por favor, insira a quantidade de vagas", eventArgs))
            {
                //Verifica se numero não é menor ou igual a 0
                if (Int32.Parse(amount_jobs.Text) <= 0)
                {
                    HandleValidationError(amount_jobs, "Por favor, insira um número maior que 0", eventArgs);
                }
            }
        }

        private bool ValidateTextBox(KryptonTextBox textBox, string message, CancelEventArgs cancelEventArgs)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                HandleValidationError(textBox, message, cancelEventArgs);
                cancelEventArgs.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, message);
                return true;
            }
            else
            {
                cancelEventArgs.Cancel = false;
                errorProvider.SetError(textBox, null);
                return false;
            }
        }

        private void HandleValidationError(KryptonTextBox textBox, string message, CancelEventArgs cancelEventArgs)
        {
            cancelEventArgs.Cancel = true;
            textBox.Focus();
            errorProvider.SetError(textBox, message);
        }

        #endregion

        #region Actions

        private void stopButton_Click(object sender, EventArgs e)
        {
            consoleRichTxtBox.Text += stringPatterns.linePattern() + "\n";
            consoleRichTxtBox.Text += "Parando aplicação!\n";
            StopAutomation?.Invoke(this, EventArgs.Empty);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Validação de campos bem sucedida
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //MECHER AQUI
                txtBox_saved_jobs.Text = "0";
                txtBox_applied_Jobs.Text = $"0/{amount_jobs.Text}"; //AQUI
                txtBoxCurrentJob.Text = txtBox_job.Text;
                consoleRichTxtBox.Clear();
                StartAutomation?.Invoke(this, EventArgs.Empty);
            }
        }

        private void HomeView_Resize(object sender, EventArgs e)
        {
            //Ajustar tamanho do console e do painel de forma responsiva
            panelConsole.Size = new Size(panelConsole.Width, this.Height - 300);
            consoleRichTxtBox.Size = new Size(consoleRichTxtBox.Width, panelConsole.Height - 20);
        }

        private void RichtxtBox_TextChanged(object sender, EventArgs e)
        {
            // definir o cursor atual para a posição final do richTextBox
            consoleRichTxtBox.SelectionStart = consoleRichTxtBox.Text.Length;
            // rolar automaticamente
            consoleRichTxtBox.ScrollToCaret();
        }

        #endregion
    }
}
