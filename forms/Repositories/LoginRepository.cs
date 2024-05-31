using forms.Models;
using Linkedin_Automation.Model;
using MessagePack;
using Newtonsoft.Json;

namespace forms.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public void delete()
        {
            throw new NotImplementedException();
        }

        public void edit(string filepath, User user)
        {
            string userJson = JsonConvert.SerializeObject(user);
            byte[] packed = MessagePackSerializer.Serialize(userJson);
            File.WriteAllBytes(filepath, packed);
        }

        public void create(string filepath)
        {
            //System.IO.Path.GetDirectoryName(Application.ExecutablePath); ///TESTE
            File.Create(filepath).Dispose();
        }

        public byte[] read(string filepath)
        {
            return File.ReadAllBytes(filepath);
        }
    }
}
