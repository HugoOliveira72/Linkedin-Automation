using forms.Presenters;
using forms.Views.Interfaces;

namespace forms.Forms
{
    public partial class LoginView : Form, ILoginView
    {
        //Properties
        public string? Email
        {
            get { return txtbox_user.Text; }
            set { txtbox_user.Text = value; }
        }
        public string? Password
        {
            get { return txtbox_password.Text; }
            set { txtbox_password.Text = value; }
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);
            HomeView view = new HomeView(this.Email, this.Password, this.IsRememberMeMarked);
            new HomePresenter(view);
            view.ShowDialog();
        }
    }
}
