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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void groupBox_login_Enter(object sender, EventArgs e)
        {

        }

        private void logiButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen(txtbox_user.Text, txtbox_password.Text);
            homeScreen.Show();
        }
    }
}
