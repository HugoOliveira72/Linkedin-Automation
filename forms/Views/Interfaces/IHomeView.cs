namespace forms.Views.Interfaces
{
    public interface IHomeView
    {
        public string? CurrentJob { get; set; }
        public int AmountOfAppliedJobs { get; set; }
        public int AmountOfSavedJobs { get; set; }
        public string? RichtxtBox { get; set; }

        //Events /actions
        event EventHandler StartAutomation;
        event EventHandler StopAutomation;
        event EventHandler LogFileEvent;
        event EventHandler StoreFilters;

    }
}
