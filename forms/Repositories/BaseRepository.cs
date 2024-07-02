using forms.Models.Interfaces;
using MessagePack;
using Newtonsoft.Json;
using System.Xml;

namespace forms.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        protected const string ConfigFilePath = "../../../Config/AppSettings.xml";

        //MessagePack Methods
        public void CreateMessagePackFile(string filepath)
        {
            File.Create(filepath).Dispose();
        }

        public byte[] ReadMessagePackFile(string filepath)
        {
            System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            return File.ReadAllBytes(filepath);
        }

        public T ReadAndConvertMessagepackFileToObject<T>(string filePath)
        {
            byte[] fileBytes = ReadMessagePackFile(filePath);

            // Desserializa os bytes em um objeto Config
            var convertedObject = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<T>(convertedObject);
        }

        public void UpdateMessagePackFile(string filepath, object obj)
        {
            string objJson = JsonConvert.SerializeObject(obj);
            byte[] packed = MessagePackSerializer.Serialize(objJson);
            File.WriteAllBytes(filepath, packed);
        }

        public void DeleteMessagePackFile()
        {
            throw new NotImplementedException();
        }

        //Text Methods
        public void CreateTextFile(string filepath)
        {
            System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            File.WriteAllText(filepath, "");
        }

        public string[] ReadTextFile(string filepath)
        {
            return File.ReadAllLines(filepath);
        }

        public void UpdateTextFile(string filepath, string text)
        {
            File.AppendAllText(filepath, Environment.NewLine + text);
        }

        public void DeleteTextFile()
        {
            throw new NotImplementedException();
        }

        //GetFilePath
        public string GetFilePath(string Xpath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(ConfigFilePath);

            // Obtém os valores do diretório
            return xmlDocument.SelectSingleNode(xpath: Xpath).InnerText;
        }
    }
}
