using MaterialRemove.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialRemove.Interfaces
{
    public interface IMaterialRemoveData
    {
        bool Enable { get; set; }
        int MinNumCells { get; set; }
        SectionsPer100mm SectionsX100mm { get; set; }
        PanelFragment PanelFragment { get; set; }
        SectionDivision SectionDivision{ get; set; }
        bool ParallelComputing { get; set; }
    }
}
