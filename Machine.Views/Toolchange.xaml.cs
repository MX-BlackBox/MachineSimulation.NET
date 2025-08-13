using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Logica di interazione per Toolchange.xaml
    /// </summary>
    public partial class Toolchange : UserControl
    {
        public Toolchange()
        {
            InitializeComponent();
            DataContext = new ToolchangeViewModel();
        }
    }
}
