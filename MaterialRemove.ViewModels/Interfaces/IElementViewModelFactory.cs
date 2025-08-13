namespace MaterialRemove.ViewModels.Interfaces
{
    public interface IElementViewModelFactory
    {
        SectionFaceViewModel CreateSectionFaceViewModel();
        SectionVolumeViewModel CreateSectionVolumeViewModel();
    }
}
