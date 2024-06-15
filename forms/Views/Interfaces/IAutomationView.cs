using static System.Windows.Forms.CheckedListBox;

namespace forms.Views.Interfaces
{
    public interface IAutomationView
    {
        public string? CurrentJob { get; set; }
        public int AmountOfAppliedJobs { get; set; }
        public int AmountOfSavedJobs { get; set; }
        public string? RichtxtBox { get; set; }
        public bool ButtonEnabled { get; set; }

        //Events /actions
        event EventHandler StartAutomation;
        event EventHandler LogFileEvent;

    }
}
