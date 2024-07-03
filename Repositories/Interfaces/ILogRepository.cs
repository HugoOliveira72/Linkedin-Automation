namespace forms.Models.Interfaces
{
    public interface ILogRepository : IBaseRepository
    {
        void WriteALogError(string message, Exception exception);
        void WriteStartMessage();
        string GetFilePath();
    }
}
