using forms.Utilities;
using Krypton.Toolkit;

namespace forms.Models.Filters
{
    public class FilterFieldsModel
    {
        public string TxtboxJob { get; set; }
        public int? AmountOfJobs { get; set; }
        public string? ClassifyBy { get; set; }
        public string? AnnoucementDate { get; set; }
        public List<string> CheckedListBoxExperiences { get; set; }
        public List<string> CheckedListBoxType_job { get; set; }
        public List<string> CheckedListBoxRemote { get; set; }
        public FilterFieldsModel(
            string txtbox_job,
            int? amount_jobs,
            string classifyBy,
            string annoucementDate,
            KryptonCheckedListBox.CheckedItemCollection ExperiencesCheckedItemCollection,
            KryptonCheckedListBox.CheckedItemCollection TypeJobCheckedItemCollection,
            KryptonCheckedListBox.CheckedItemCollection RemoteCheckedItemCollection
            )
        {
            TxtboxJob = txtbox_job;
            AmountOfJobs = amount_jobs;
            ClassifyBy = classifyBy;
            AnnoucementDate = annoucementDate;
            CheckedListBoxExperiences = ExperiencesCheckedItemCollection.ToList();
            CheckedListBoxType_job = TypeJobCheckedItemCollection.ToList();
            CheckedListBoxRemote = RemoteCheckedItemCollection.ToList();
        }
    }
}
