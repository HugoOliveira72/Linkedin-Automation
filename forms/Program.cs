using forms.Forms;
using forms.Presenters;
using forms.Views;

namespace forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = "";
            ILoginView loginView = new LoginView();
            //ILoginRepository loginRepository
            new LoginPresenter(loginView);
            Application.Run((Form)loginView);
        }
    }
}