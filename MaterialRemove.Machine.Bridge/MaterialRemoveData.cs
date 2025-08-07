using MaterialRemove.Interfaces;
using MaterialRemove.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialRemove.Machine.Bridge
{
    public class MaterialRemoveData : IMaterialRemoveData
    {
        public bool Enable { get; set; }
        public int MinNumCells { get; set; } = 16;
        public SectionsPer100mm SectionsX100mm { get; set; }
        public PanelFragment PanelFragment { get; set; }
        public SectionDivision SectionDivision { get; set; }
        public bool ParallelComputing { get; set; }
    }
}
