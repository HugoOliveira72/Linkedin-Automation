using forms.Models.Interfaces;
using forms.Presenters;
using forms.Presenters.Services;
using forms.Repositories;
using forms.Views.Interfaces;
using Krypton.Toolkit;
using System.ComponentModel;

namespace forms.Forms
{
    public partial class LoginView : Form, ILoginView
    {
        private ErrorProvider errorProvider = new();
        //Properties
        public string? Email
        {
            get { return userTxtBox.Text; }
            set { userTxtBox.Text = value; }
        }
        public string? Password
        {
            get { return passwordTxtBox.Text; }
            set { passwordTxtBox.Text = value; }
        }

        public bool IsRememberMeMarked
        {
            get { return checkbox_rememberMe.Checked; }
            set { checkbox_rememberMe.Checked = value; }
        }

        //Events
        public event EventHandler LoginEvent;
        public event EventHandler UserFormLoaded;

        //Constructor
        public LoginView()
        {
            InitializeComponent();
            this.Load += OnFormLoaded;
        }

        //Methods
        private void OnFormLoaded(object sender, EventArgs e)
        {
            UserFormLoaded?.Invoke(this, EventArgs.Empty);
        }

        private void kryptonLoginButton_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);

            IDataService<dynamic> dataService = new DataService<dynamic>();
            ILogRepository logRepository = new LogRepository();
            ILogService logService = new LogService(logRepository);
            ILoginRepository loginRepository = new LoginRepository();
            IConfigRepository configRepository = new ConfigRepository();
            HomeView homeView = new HomeView(dataService);
            new HomePresenter(homeView, dataService, logService, loginRepository, logRepository, configRepository);
            Hide();
            homeView.ShowDialog();
            Show();
        }

        private void UserTxtBox_Validating(object sender, CancelEventArgs e)
        {
            //Verifica se campo está vazio
            ValidateTextBox(userTxtBox, "Por favor, insira o usuário", e);
        }

        private void PasswordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(passwordTxtBox, "Por favor, insira a senha", e);
        }

        private bool ValidateTextBox(KryptonTextBox textBox, string message, CancelEventArgs cancelEventArgs)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                HandleValidationError(textBox, message, cancelEventArgs);
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
            //textBox.Focus();
            errorProvider.SetError(textBox, message);
        }
    }
}
