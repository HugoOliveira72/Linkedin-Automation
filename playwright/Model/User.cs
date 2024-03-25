namespace Linkedin_Automation.Model
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }

        public User(string email, string pass)
        {
            this.email = email;
            this.password = pass;
        }
    }
}
