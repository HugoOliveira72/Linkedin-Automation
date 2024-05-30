namespace forms.Views
{
    public interface ILoginView
    {
        //Properties - Fields
        public string? Email { get; set; }
        public string? Password { get; set; }

        //Events /acitions
        event EventHandler LoginEvent;

    }
}
