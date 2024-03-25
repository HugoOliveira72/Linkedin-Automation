using Linkedin_Automation.Credencials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }


        private void mainScreen_Load(object sender, EventArgs e)
        {

        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (txtbox_job.Text == ".net")
            {
                MessageBox.Show("DEU BOM!");
            }

            var a = new Credencials();
        }
    }
}
