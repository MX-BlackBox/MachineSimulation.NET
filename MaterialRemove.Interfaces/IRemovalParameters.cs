using MaterialRemove.Interfaces.Enums;

namespace MaterialRemove.Interfaces
{
    public interface IRemovalParameters
    {
        int NumCells { get; set; }
        int SectionsX100mm { get; set; }
        public double CubeSize { get; set; }
        public double FilterMargin { get; set; }
        PanelFragment PanelFragment { get; set; }
        int SectionDivision { get; set; }
        bool ParallelComputing { get; set; }
    }
}
