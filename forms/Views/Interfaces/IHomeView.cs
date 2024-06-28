namespace forms.Views.Interfaces
{
    public interface IHomeView
    {
        public string Job { get; set; }
        public string AmountJobs { get; set; }
        public string? CurrentJob { get; set; }
        public int AmountOfAppliedJobs { get; set; }
        public int AmountOfSavedJobs { get; set; }
        public string? RichtxtBox { get; set; }
        public bool ButtonEnabled { get; set; }

        //Events /actions
        event EventHandler StartAutomation;
        event EventHandler StopAutomation;
        event EventHandler LogFileEvent;
        event EventHandler StoreFilters;

    }
}
