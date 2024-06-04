namespace forms.Services
{
    public class DataService<T> : IDataService<T>
    {
        private T _data;

        public void SetData(T data)
        {
            _data = data;
        }

        public T GetData()
        {
            return _data;
        }
    }
}
