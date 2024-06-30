using forms.Models.Interfaces;
using Linkedin_Automation.Model;
using MessagePack;
using Newtonsoft.Json;

namespace forms.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        private const string UserDirectoryXpath = "/config/userDirectoryPath";

        public UserModel ReadAndConvertMsgpackFileToObject()
        {
            byte[] fileBytes = ReadMessagePackFile(GetFilePath());

            // Desserializa os bytes em um objeto Config
            var convertedObject = MessagePackSerializer.Deserialize<dynamic>(fileBytes);
            return JsonConvert.DeserializeObject<UserModel>(convertedObject);
        }

        public string GetFilePath()
        {
            return GetFilePath(UserDirectoryXpath);
        }
    }
}
