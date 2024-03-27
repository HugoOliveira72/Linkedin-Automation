using playwright.Model;
using System.Windows.Forms;

namespace forms.Forms
{
    public partial class RunningScreen : Form
    {
        private FormObject mainScreenForm { get; set; }

        public RunningScreen()
        {
            InitializeComponent();

        }

        public RunningScreen(FormObject formObject)
        {
            InitializeComponent();
            this.mainScreenForm = formObject;
            //this.Load += new EventHandler(RunningScreen_Load);

            this.Shown += new EventHandler(RunningScreen_Shown);
        }

        private async void RunningScreen_Load(object sender, EventArgs e)
        {
            //await Script.Main(this.mainScreenForm);
        }

        public async void RunningScreen_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Tela carregada", "Aviso", MessageBoxButtons.OK);

            txtBoxsaved_jobs.Text = "0";
            txtBox_applied_Jobs.Text = $"0/{mainScreenForm.AmoutOfJobs}";
            txtBox_job.Text = mainScreenForm.TxtboxJob;

            await Script.Main(this.mainScreenForm);
        }

        public void appendRichTextBoxText(string text)
        {
            richtxtBox_info.Text += text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Seu código aqui
        }
    }
}
