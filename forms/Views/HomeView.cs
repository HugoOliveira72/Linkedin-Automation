﻿using forms.Models.Filters;
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
        private IDataService<dynamic> _dataService;
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
            get { return richtxtBox.Text; }
            set { richtxtBox.Text = value; }
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopAutomation?.Invoke(this, EventArgs.Empty);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Validação de campos bem sucedida
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                txtBox_saved_jobs.Text = "0";
                txtBox_applied_Jobs.Text = $"0/{amount_jobs.Text}";
                txtBoxCurrentJob.Text = txtBox_job.Text;
                richtxtBox.Clear();
                StartAutomation?.Invoke(this, EventArgs.Empty);
            }
        }

        private void HomeView_Resize(object sender, EventArgs e)
        {
            //Ajustar tamanho do console e do painel de forma responsiva
            panelConsole.Size = new Size(panelConsole.Width, this.Height - 300);
            richtxtBox.Size = new Size(richtxtBox.Width, panelConsole.Height - 20);
        }

    }
}
