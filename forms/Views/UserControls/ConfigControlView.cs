using forms.Views.Interfaces.Control;

namespace forms.Views.UserControls
{
    public partial class ConfigControlView : UserControl, IConfigControlView
    {
        public ConfigControlView()
        {
            InitializeComponent();
            this.Load += OnFormLoaded;
            AssociateAndRaiseViewEvents();
        }
        
        //Properties
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

        //Methods
        private void comboBox_resolution_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_resolution.Enabled = (comboBox_resolution_type.Text == "Tela cheia") ? false : true;
            AssociateAndRaiseViewEvents();
        }

        private void comboBox_resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
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
            SaveConfigEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
