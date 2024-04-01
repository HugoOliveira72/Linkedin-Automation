namespace forms.Model
{
    public class ScreenConfiguration
    {
        public string? ScreenType { get; set; }
        public string? Resolution { get; set; }

        public ScreenConfiguration(string screenType, string resolution)
        {
            this.ScreenType = screenType;
            this.Resolution = resolution;
        }
    }
}
