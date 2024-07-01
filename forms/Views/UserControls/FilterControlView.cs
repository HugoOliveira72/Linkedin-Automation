using forms.Models.Filters;
using forms.Views.Interfaces.Control;
using static Krypton.Toolkit.KryptonCheckedListBox;

namespace forms.Views
{
    public partial class FilterControlView : UserControl, IFilterControlView
    {
        //Fields
        public string ComboBoxClassifyBy
        {
            get { return comboBox_classify_by.Text; }
            set { comboBox_classify_by.Text = value; }
        }
        public string comboBoxAnnoucementDate
        {
            get { return comboBox_annoucement_date.Text; }
            set { comboBox_annoucement_date.Text = value; }
        }
        public CheckedItemCollection checkedListBoxExperienceLevel
        {
            get { return checkedListBox_experience_level.CheckedItems; }
        }
        public CheckedItemCollection checkedListBoxTypeJob
        {
            get { return checkedListBox_type_job.CheckedItems; }
        }
        public CheckedItemCollection checkedListBoxRemote
        {
            get { return checkedListBox_remote.CheckedItems; }
        }

        //Constructor
        public FilterControlView(FilterFieldsModel filterFieldsModel = null)
        {
            InitializeComponent();
            if (filterFieldsModel != null)
                SetFilterModelFieldsToAttributes(filterFieldsModel);
        }

        //Events
        public event EventHandler HandleFilter;

        /// Validating fields 
        private void ComboBox_choose_by_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            handleAndRaiseEvents();
        }

        private void ComboBox_annoucement_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void CheckedListBox_experience_level_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void CheckedListBox_type_job_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void CheckedListBox_remote_MouseLeave(object sender, EventArgs e)
        {
            handleAndRaiseEvents();
        }

        private void handleAndRaiseEvents()
        {
            HandleFilter?.Invoke(this, EventArgs.Empty);
        }

        private void SetFilterModelFieldsToAttributes(FilterFieldsModel fieldsModel)
        {
            comboBox_classify_by.Text = fieldsModel.ClassifyBy;
            comboBox_annoucement_date.Text = fieldsModel.AnnoucementDate;
        }

    }
}
