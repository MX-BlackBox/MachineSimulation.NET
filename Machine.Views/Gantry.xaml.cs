using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Logica di interazione per Gantry.xaml
    /// </summary>
    public partial class Gantry : UserControl
    {
        public Gantry()
        {
            InitializeComponent();
            DataContext = new GantryLinksViewModel();
        }
    }
}
