namespace forms.Presenters.Services
{
    public interface IDataService<T>
    {
        void SetData(T data);

        T GetData();
    }
}
