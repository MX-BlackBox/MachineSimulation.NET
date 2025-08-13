using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Interaction logic for Tools.xaml
    /// </summary>
    public partial class Tools : UserControl
    {
        public Tools()
        {
            InitializeComponent();
            DataContext = new ToolsViewModel();
        }
    }
}
