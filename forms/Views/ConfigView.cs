using forms.Model;
using forms.Views.Interfaces;

namespace forms.Forms
{
    public partial class ConfigView : Form, IConfigView
    {

        //Fields
        public string? ResolutionType
        {
            get { return comboBox_resolution_type.Text; }
            set { comboBox_resolution_type.Text = value; }
        }

        public string? Resolution
        {
            get { return comboBox_resolution.Text; }
            set { comboBox_resolution.Text = value; }
        }

        //Events
        public event EventHandler ConfigFormLoaded;
        public event EventHandler SaveConfigEvent;

        //Constructor
        public ConfigView()
        {
            InitializeComponent();
            this.Load += OnFormLoaded;
            AssociateAndRaiseViewEvents();
        }

        private void comboBox_resolution_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_resolution.Enabled = (comboBox_resolution_type.Text == "Tela cheia") ? false : true;
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            //Quando formulário carregado
            //Define no field primeiro item selecionado
            comboBox_resolution_type.SelectedIndex = 0;
            ConfigFormLoaded?.Invoke(this, EventArgs.Empty);
        }

        private void AssociateAndRaiseViewEvents()
        {
            button_save_configs.Click += delegate { SaveConfigEvent?.Invoke(this, EventArgs.Empty); };
        }
    }
}
