using Machine.Views.ViewModels;
using System.Windows.Controls;
using MVMUI = Machine.ViewModels.UI;
using MVMIoc = Machine.ViewModels.Ioc;
using MSVMI = Machine.Steps.ViewModels.Interfaces;

namespace Machine.Views
{
    /// <summary>
    /// Logica di interazione per Steps.xaml
    /// </summary>
    public partial class Steps : UserControl
    {
        public Steps()
        {
            InitializeComponent();
            var vm = new StepsViewModel();
            DataContext = vm;
            MVMIoc.SimpleIoc<MVMUI.IStepsController>.Register(vm);
            MVMIoc.SimpleIoc<MVMUI.IStepsExecutionController>.Register(vm);
            MVMIoc.SimpleIoc<MSVMI.IStepsContainer>.Register(vm);
        }

        private void OnListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listView.ScrollIntoView(listView.SelectedItem);
        }
    }
}
