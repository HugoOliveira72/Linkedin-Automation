using forms.Model;
using NPOI.SS.Formula.Functions;

namespace forms.Models.Interfaces
{
    public interface IBaseRepository
    {

        public void create(string filepath);
        public byte[] read(string filepath);
        public T LoadConvertedObject<T>(string filePath);
        public void update(string filepath, object obj);
        public void delete();


    }
}
