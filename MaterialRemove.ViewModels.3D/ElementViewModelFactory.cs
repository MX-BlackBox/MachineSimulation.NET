using MaterialRemove.ViewModels.Interfaces;

namespace MaterialRemove.ViewModels._3D
{
    public class ElementViewModelFactory : IElementViewModelFactory
    {
        public ViewModels.SectionFaceViewModel CreateSectionFaceViewModel() => new SectionFaceViewModel();

        public ViewModels.SectionVolumeViewModel CreateSectionVolumeViewModel() => new SectionVolumeViewModel();
    }
}
