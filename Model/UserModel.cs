namespace Linkedin_Automation.Model
{
    public class UserModel
    {
        public string email { get; set; }
        public string password { get; set; }

        public UserModel(string email, string pass)
        {
            this.email = email;
            this.password = pass;
        }
    }
}
