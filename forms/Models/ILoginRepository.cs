using Linkedin_Automation.Model;

namespace forms.Models
{
    public interface ILoginRepository
    {
        void create(string filepath);
        void delete();
        void edit(string filepath, User user);
        byte[] read(string filepath);
    }
}
