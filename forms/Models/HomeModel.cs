using forms.Model;
using forms.Utilities;

namespace playwright.Model
{
    public class HomeModel
    {
        public string TxtboxJob { get; set; }
        public int AmoutOfJobs { get; set; }
        public string? ClassifyBy { get; set; }
        public string? AnnoucementDate { get; set; }
        public List<string> CheckedListBoxExperiences { get; set; }
        public List<string> CheckedListBoxType_job { get; set; }
        public List<string> CheckedListBoxRemote { get; set; }
        public HomeModel(
            string txtbox_job,
            int amount_jobs,
            string classifyBy,
            string annoucementDate,
            CheckedListBox.CheckedItemCollection ExperiencesCheckedItemCollection,
            CheckedListBox.CheckedItemCollection TypeJobCheckedItemCollection,
            CheckedListBox.CheckedItemCollection RemoteCheckedItemCollection
            )
        {
            this.TxtboxJob = txtbox_job;
            this.AmoutOfJobs = amount_jobs;
            this.ClassifyBy = classifyBy;
            this.AnnoucementDate = annoucementDate;
            this.CheckedListBoxExperiences = ExperiencesCheckedItemCollection.ToList();
            this.CheckedListBoxType_job = TypeJobCheckedItemCollection.ToList();
            this.CheckedListBoxRemote = RemoteCheckedItemCollection.ToList();
        }
    }
}
