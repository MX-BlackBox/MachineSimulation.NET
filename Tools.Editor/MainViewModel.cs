using System.Collections.Generic;
using M3DVE = Machine._3D.Views.Enums;
using VMUI = Machine.ViewModels.UI;
using M3DVI = Machine._3D.Views.Interfaces;
using MVMUI = Machine.ViewModels.UI;
using MVM = Machine.ViewModels;

namespace Tools.Editor
{
    internal class MainViewModel : Machine.ViewModels.MainViewModel
    {
        public M3DVI.IBackgroundColor BackgroundColor => MVM.Ioc.SimpleIoc<M3DVI.IBackgroundColor>.GetInstance();
        public VMUI.IOptionProvider<M3DVE.LightType> LightType => MVM.Ioc.SimpleIoc<VMUI.IOptionProvider<M3DVE.LightType>>.GetInstance();
        public ICollection<VMUI.IFlag> View3DFlags => MVM.Ioc.SimpleIoc<VMUI.IPeropertiesProvider>.GetInstance().Flags;
        public ICollection<VMUI.IOptionProvider> View3DOptions => MVM.Ioc.SimpleIoc<VMUI.IPeropertiesProvider>.GetInstance().Options;
        public VMUI.IOptionProvider DataSource => MVM.Ioc.SimpleIoc<VMUI.IOptionProvider>.GetInstance();
        public MVMUI.IIndicatorsViewController IndicatorsController => MVM.Ioc.SimpleIoc<MVMUI.IIndicatorsViewController>.GetInstance();
        public VMUI.IToolsetEditor ToolsetEditor => MVM.Ioc.SimpleIoc<VMUI.IToolsetEditor>.GetInstance();
        public VMUI.IDataUnloader DataUnloader => MVM.Ioc.SimpleIoc<VMUI.IDataUnloader>.GetInstance();

        public MainViewModel()
        {

        }
    }
}
