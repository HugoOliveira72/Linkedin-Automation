using forms.Views;
using forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms.Forms
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            //this.Close();
        }

        //Properties
        public string? Email
        {
            get { return txtbox_user.Text; }
            set { txtbox_user.Text = value;}
        }
        public string? Password
        {
            get { return txtbox_password.Text; }
            set { txtbox_password.Text = value; }
        }

        //Events
        public event EventHandler LoginEvent;

        private void AssociateAndRaiseViewEvents()
        {
            loginButton.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
        }

        //private void logiButton_Click(object sender, EventArgs e)
        //{
        //    HomeScreen homeScreen = new HomeScreen(txtbox_user.Text, txtbox_password.Text);
        //    homeScreen.Show();
        //}
    }
}
