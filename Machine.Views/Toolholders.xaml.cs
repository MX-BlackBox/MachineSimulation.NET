using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Interaction logic for Toolholders.xaml
    /// </summary>
    public partial class Toolholders : UserControl
    {
        public Toolholders()
        {
            InitializeComponent();
            DataContext = new ToolholdersViewModel();
        }
    }
}
