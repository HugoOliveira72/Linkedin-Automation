namespace forms.Models.Interfaces
{
    public interface IConfigRepository : IBaseRepository
    {
        string? GetConfigFilePath();
        public T ConvertMsgpackFileToObject<T>();

    }
}
