using forms.Views.Interfaces.Control;

namespace forms.Views.UserControls
{
    public partial class ConfigControlView : UserControl, IConfigControlView
    {
        public ConfigControlView()
        {
            InitializeComponent();
            this.Load += OnFormLoaded;
        }
        
        //Properties
        public string? ResolutionType
        {
            get { return comboBox_resolution_type.Text; }
            set { comboBox_resolution_type.Text = value; }
        }
        public int ResolutionTypeSelectedIndex
        {
            get { return comboBox_resolution_type.SelectedIndex; }
            set { comboBox_resolution.SelectedIndex = value; }
        }
        public string? Resolution
        {
            get { return comboBox_resolution.Text; }
            set { comboBox_resolution.Text = value; }
        }


        //Events
        public event EventHandler ConfigFormLoaded;
        public event EventHandler SaveConfigEvent;
        public event EventHandler UpdateComponentsEvent;

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
            ConfigFormLoaded?.Invoke(this, EventArgs.Empty);
        }

        private void AssociateAndRaiseViewEvents()
        {
            SaveConfigEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
