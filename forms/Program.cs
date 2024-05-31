using forms.Forms;
using forms.Models.Interfaces;
using forms.Presenters;
using forms.Repositories;
using forms.Views.Interfaces;

namespace forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = "";
            ILoginView loginView = new LoginView();
            ILoginRepository loginRepository = new LoginRepository();
            new LoginPresenter(loginView, loginRepository);
            Application.Run((Form)loginView);
        }
    }
}