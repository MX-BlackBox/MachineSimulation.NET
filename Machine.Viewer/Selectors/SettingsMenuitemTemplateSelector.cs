using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Machine.Viewer.Selectors
{
    [ContentProperty("Templates")]
    class SettingsMenuitemTemplateSelector : ItemContainerTemplateSelector
    {
        public List<SettingsMenuitemTemplateSelectorItem> Templates { get; private set; } = new List<SettingsMenuitemTemplateSelectorItem>();

        public override DataTemplate SelectTemplate(object item, ItemsControl parentItemsControl)
        {
            return base.SelectTemplate(item, parentItemsControl);
        }
    }

    [ContentProperty("Then")]
    class SettingsMenuitemTemplateSelectorItem
    {
        public string When { get; set; }
        public object Then { get; set; }
    }
}
