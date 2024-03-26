namespace playwright.Model
{
    public class FormObject
    {
        public string TxtboxUser { get; set; }
        public string TxtboxPassword { get; set; }
        public bool CheckboxWriteCredentials { get; set; }
        public string TxtboxJob { get; set; }
        public int AmoutOfJobs { get; set; }

        public FormObject(
            string txtbox_user,
            string txtbox_password,
            bool checkbox_write_credentials_in_file,
            string txtbox_job,
            int amount_jobs
            )
        {
            this.TxtboxUser = txtbox_user;
            this.TxtboxPassword = txtbox_password;
            this.CheckboxWriteCredentials = checkbox_write_credentials_in_file;
            this.TxtboxJob = txtbox_job;
            this.AmoutOfJobs = amount_jobs;
        }
    }
}
