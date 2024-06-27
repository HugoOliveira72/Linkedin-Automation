using forms.Utilities;
using Krypton.Toolkit;

namespace forms.Models.Filters
{
    public class FilterFieldsModel
    {
        public string? ClassifyBy { get; set; }
        public string? AnnoucementDate { get; set; }
        public List<string> CheckedListBoxExperiences { get; set; }
        public List<string> CheckedListBoxType_job { get; set; }
        public List<string> CheckedListBoxRemote { get; set; }
        public FilterFieldsModel(
            string classifyBy,
            string annoucementDate,
            KryptonCheckedListBox.CheckedItemCollection ExperiencesCheckedItemCollection,
            KryptonCheckedListBox.CheckedItemCollection TypeJobCheckedItemCollection,
            KryptonCheckedListBox.CheckedItemCollection RemoteCheckedItemCollection
            )
        {
            ClassifyBy = classifyBy;
            AnnoucementDate = annoucementDate;
            CheckedListBoxExperiences = ExperiencesCheckedItemCollection.ToList();
            CheckedListBoxType_job = TypeJobCheckedItemCollection.ToList();
            CheckedListBoxRemote = RemoteCheckedItemCollection.ToList();
        }
    }
}
