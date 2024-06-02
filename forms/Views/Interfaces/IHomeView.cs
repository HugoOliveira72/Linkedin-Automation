using static System.Windows.Forms.CheckedListBox;

namespace forms.Views.Interfaces
{
    public interface IHomeView
    {
        public string Job { get; set; }
        public string amountJobs { get; set; }
        public string ComboBoxClassifyBy { get; set; }
        public string comboBoxAnnoucementDate { get; set; }
        public CheckedItemCollection checkedListBoxExperienceLevel { get; }
        public CheckedItemCollection checkedListBoxTypeJob { get; }
        public CheckedItemCollection checkedListBoxRemote { get; }

        //Events /actions
        event EventHandler ShowConfigView;
        event EventHandler ShowRunningView;
    }
}
