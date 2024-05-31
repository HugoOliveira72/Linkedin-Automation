using forms.Model;
using forms.Models.Interfaces;
using Linkedin_Automation.Model;
using MessagePack;
using Newtonsoft.Json;

namespace forms.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public void create(string filepath)
        {
            File.Create(filepath).Dispose();
        }

        public byte[] read(string filepath)
        {
            return File.ReadAllBytes(filepath);
        }

        public void update(string filepath, object obj)
        {
            string objJson = JsonConvert.SerializeObject(obj);
            byte[] packed = MessagePackSerializer.Serialize(objJson);
            File.WriteAllBytes(filepath, packed);
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public T LoadConvertedObject<T>(string filePath)
        {
            byte[] fileBytes = read(filePath);

            // Desserializa os bytes em um objeto Config
            var convertedObject = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<T>(convertedObject);
        }

    }
}
