using forms.Views;

namespace forms.Presenters
{
    public class LoginPresenter
    {
        //Fields
        private ILoginView _loginView;

        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
            _loginView.LoginEvent += LoginEvent;
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            //HomeScreen homeScreen = new HomeScreen(txtbox_user.Text, txtbox_password.Text);
            HomeScreen homeScreen = new HomeScreen(_loginView.Email,_loginView.Password);
            homeScreen.Show();
        }
    }
}
