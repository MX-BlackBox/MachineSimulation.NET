using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Interaction logic for Tooling.xaml
    /// </summary>
    public partial class Tooling : UserControl
    {
        public Tooling()
        {
            InitializeComponent();
            DataContext = new ToolingViewModel();
        }
    }
}
