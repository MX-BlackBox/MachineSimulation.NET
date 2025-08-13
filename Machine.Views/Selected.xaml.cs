using Machine.ViewModels.UI;
using Machine.Views.ViewModels;
using System.Windows.Controls;

namespace Machine.Views
{
    /// <summary>
    /// Interaction logic for Selected.xaml
    /// </summary>
    public partial class Selected : UserControl
    {
        public Selected()
        {
            InitializeComponent();
            var vm = new SelectedViewModel();
            Machine.ViewModels.Ioc.SimpleIoc<IMachineStructEditor>.Register(vm);
            DataContext = vm;
        }
    }
}
