using Linkedin_Automation.Model;

namespace forms.Models.Interfaces
{
    public interface ILoginRepository : IBaseRepository
    {
        UserModel ReadAndConvertMsgpackFileToObject();
        string GetFilePath();
    }
}
