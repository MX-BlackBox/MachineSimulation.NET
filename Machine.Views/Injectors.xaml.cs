using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Logica di interazione per Injectors.xaml
    /// </summary>
    public partial class Injectors : UserControl
    {
        public Injectors()
        {
            InitializeComponent();
            DataContext = new InjectorsViewModel();
        }
    }
}
