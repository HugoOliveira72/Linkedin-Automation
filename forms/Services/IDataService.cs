using NPOI.SS.Formula.Functions;

namespace forms.Services
{
    public interface IDataService<T>
    {
        void SetData(T data);

        T GetData();
    }
}
