
using static Krypton.Toolkit.KryptonCheckedListBox;

namespace forms.Views.Interfaces.Control
{
    public interface IFilterControlView
    {
        public string ComboBoxClassifyBy { get; set; }
        public string comboBoxAnnoucementDate { get; set; }
        public CheckedItemCollection checkedListBoxExperienceLevel { get; }
        public CheckedItemCollection checkedListBoxTypeJob { get; }
        public CheckedItemCollection checkedListBoxRemote { get; }

        event EventHandler HandleFilter;
    }
}
