using Machine.Data.Enums;
using Machine.ViewModels.Interfaces.MachineElements;
using System.ComponentModel;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Machine.Views.ViewModels.MachineElementProxies
{
    [CategoryOrder("Root data", 2)]
    public class RootProxyViewModel : ElementProxyViewModel
    {
        private IRootElement RootElement => _element as IRootElement;

        [Category("Root data")]
        [PropertyOrder(0)]
        public string AssemblyName 
        {
            get => RootElement.AssemblyName;
            set => RootElement.AssemblyName = value;
        }

        [Category("Root data")]
        [PropertyOrder(1)]
        public RootType RootType 
        { 
            get => RootElement.RootType; 
            set => RootElement.RootType = value; 
        }

        public RootProxyViewModel(IRootElement element) : base(element)
        {
        }
    }
}
