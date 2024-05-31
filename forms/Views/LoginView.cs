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
using forms.Views.Interfaces;
using Linkedin_Automation.Model;

namespace forms.Forms
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            this.Load += OnFormLoaded;
            AssociateAndRaiseViewEvents();
        }

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

        //Events
        public event EventHandler LoginEvent;
        public event EventHandler UserFormLoaded;

        //Methods
        private void AssociateAndRaiseViewEvents()
        {
            loginButton.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            UserFormLoaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
