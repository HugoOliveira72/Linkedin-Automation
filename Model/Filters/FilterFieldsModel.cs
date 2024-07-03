using forms.Utilities;
using Krypton.Toolkit;

namespace forms.Models.Filters
{
    public class FilterFieldsModel
    {
        public string? ClassifyBy { get; set; }
        public string? AnnoucementDate { get; set; }
        //CheckedListItens
        public List<string> CheckedListBoxExperiences { get; set; }
        public List<string> CheckedListBoxType_job { get; set; }
        public List<string> CheckedListBoxRemote { get; set; }
        public FilterFieldsModel(
            string classifyBy,
            string annoucementDate,
            KryptonCheckedListBox.CheckedItemCollection ExperiencesCheckedItemCollection,
            KryptonCheckedListBox.CheckedItemCollection TypeJobCheckedItemCollection,
            KryptonCheckedListBox.CheckedItemCollection RemoteCheckedItemCollection,
            bool ConvertItens = false
            )
        {
            ClassifyBy = classifyBy;
            AnnoucementDate = annoucementDate;
            if (!ConvertItens)
            {
                CheckedListBoxExperiences = ExperiencesCheckedItemCollection.ToList();
                CheckedListBoxType_job = TypeJobCheckedItemCollection.ToList();
                CheckedListBoxRemote = RemoteCheckedItemCollection.ToList();
            }
            else
            {
                CheckedItemCollectionExperiences = ExperiencesCheckedItemCollection;
                CheckedItemCollectionType_job = TypeJobCheckedItemCollection;
                CheckedItemCollectionRemote = RemoteCheckedItemCollection;
            }
        }

        //CheckedItems
        public KryptonCheckedListBox.CheckedItemCollection CheckedItemCollectionExperiences { get; set; }
        public KryptonCheckedListBox.CheckedItemCollection CheckedItemCollectionType_job { get; set; }
        public KryptonCheckedListBox.CheckedItemCollection CheckedItemCollectionRemote { get; set; }
    }
}
