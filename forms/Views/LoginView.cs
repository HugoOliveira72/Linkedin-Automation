using forms.Models.Interfaces;
using forms.Presenters;
using forms.Repositories;
using forms.Services;
using forms.Views.Interfaces;

namespace forms.Forms
{
    public partial class LoginView : Form, ILoginView
    {
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
            HomeView view = new HomeView(dataService);
            new HomePresenter(view, dataService, logService, loginRepository, logRepository);
            view.ShowDialog();
        }
    }
}
