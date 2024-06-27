
using static Krypton.Toolkit.KryptonCheckedListBox;

namespace forms.Views.Interfaces.Control
{
    public interface IFilterControlView
    {
        public string Job { get; set; }
        public string amountJobs { get; set; }
        public string ComboBoxClassifyBy { get; set; }
        public string comboBoxAnnoucementDate { get; set; }
        public CheckedItemCollection checkedListBoxExperienceLevel { get; }
        public CheckedItemCollection checkedListBoxTypeJob { get; }
        public CheckedItemCollection checkedListBoxRemote { get; }

        event EventHandler HandleFilter;
    }
}
