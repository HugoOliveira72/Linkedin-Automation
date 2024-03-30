using forms.Utilities;

namespace playwright.Model
{
    public class FormObject
    {
        public string TxtboxUser { get; set; }
        public string TxtboxPassword { get; set; }
        public bool CheckboxWriteCredentials { get; set; }
        public string TxtboxJob { get; set; }
        public int AmoutOfJobs { get; set; }
        public string? ClassifyBy { get; set; }
        public List<string> CheckedListBoxExperiences { get; set; }
        public List<string> CheckedListBoxType_job { get; set; }
        public List<string> CheckedListBoxRemote { get; set; }
        public FormObject(
            string txtbox_user,
            string txtbox_password,
            bool checkbox_write_credentials_in_file,
            string txtbox_job,
            int amount_jobs,
            string classifyBy,
            CheckedListBox.CheckedItemCollection ExperiencesCheckedItemCollection,
            CheckedListBox.CheckedItemCollection TypeJobCheckedItemCollection,
            CheckedListBox.CheckedItemCollection RemoteCheckedItemCollection
            )
        {
            this.TxtboxUser = txtbox_user;
            this.TxtboxPassword = txtbox_password;
            this.CheckboxWriteCredentials = checkbox_write_credentials_in_file;
            this.TxtboxJob = txtbox_job;
            this.AmoutOfJobs = amount_jobs;
            this.ClassifyBy = classifyBy;
            this.CheckedListBoxExperiences = ExperiencesCheckedItemCollection.ToList();
            this.CheckedListBoxType_job = TypeJobCheckedItemCollection.ToList();
            this.CheckedListBoxRemote = RemoteCheckedItemCollection.ToList();
        }
    }
}
