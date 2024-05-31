namespace forms.Model
{
    public class ConfigurationModel
    {
        public string? ScreenType { get; set; }
        public string? Resolution { get; set; }

        public ConfigurationModel()
        {
        }

        public ConfigurationModel(string screenType, string resolution)
        {
            this.ScreenType = screenType;
            this.Resolution = resolution;
        }
    }
}
