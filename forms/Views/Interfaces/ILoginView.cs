using Linkedin_Automation.Model;

namespace forms.Views.Interfaces
{
    public interface ILoginView
    {
        //Properties - Fields
        public string? Email { get; set; }
        public string? Password { get; set; }

        //Events /acitions
        event EventHandler LoginEvent;
        event EventHandler UserFormLoaded;
    }
}
