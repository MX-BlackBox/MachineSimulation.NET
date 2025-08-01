using MaterialRemove.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialRemove.ViewModels.Interfaces
{
    internal interface ILazyPanelSection : IPanelSection
    {
        bool IsExploded { get; }
        IPanelSection ThresholdToExplode { get; }

        IList<IPanelSection> GetSubSections();
    }
}
