using Machine.ViewModels.UI;
using System.Collections.Generic;

namespace Machine.Views.UI
{
    public class ListDialog : IListDialog
    {
        public IEnumerable<string> Options { get; set; }
        public string Selection { get; set; }
        public string Title { get; set; }

        public bool ShowDialog()
        {
            var result = false;
            var dlg = new Views.ListDialog() { DataContext = this };
            var res = dlg.ShowDialog();

            if((res != null) && res.Value && !string.IsNullOrEmpty(Selection))
            {
                result = true;
            }

            return result;
        }
    }
}
