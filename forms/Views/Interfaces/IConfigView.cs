namespace forms.Views.Interfaces
{
    public interface IConfigView
    {
        public string? ResolutionType { get; set; }
        public string? Resolution { get; set; }

        //Events /acitions
        event EventHandler SaveConfigEvent;
        event EventHandler ConfigFormLoaded;
    }
}
