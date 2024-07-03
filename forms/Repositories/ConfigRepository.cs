using forms.Models.Interfaces;
using MessagePack;
using Newtonsoft.Json;
using System.Xml;

namespace forms.Repositories
{
    public class ConfigRepository : BaseRepository, IConfigRepository
    {
        private const string ResolutionDirectoryXpath = "/config/resolutionDirectoryPath";
        public T ConvertMsgpackFileToObject<T>()
        {
            byte[] fileBytes = ReadMessagePackFile(ResolutionDirectoryXpath);

            // Desserializa os bytes em um objeto Config
            var convertedObject = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<T>(convertedObject);
        }

        public string? GetConfigFilePath()
        {
            return GetFilePath(ResolutionDirectoryXpath);
        }
    }
}
