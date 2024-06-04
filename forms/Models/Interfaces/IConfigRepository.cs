namespace forms.Models.Interfaces
{
    public interface IConfigRepository : IBaseRepository
    {
        string? GetResolutionFilePath();
        public T ConvertMsgpackFileToObject<T>();

    }
}
