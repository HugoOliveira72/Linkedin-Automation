using Krypton.Toolkit;

namespace forms.Utilities
{
    public static class Extensions
    {
        public static List<string> ToList(this KryptonCheckedListBox.CheckedItemCollection collection)
        {
            return collection.Cast<object>().Select(item => item.ToString()).ToList();
        } 
    }
}
