using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaterialRemove.Interfaces
{
    public interface IPanel : IRemovalParameters
    {
        double SizeX { get; set; }
        double SizeY { get; set; }
        double SizeZ { get; set; }
        ICollection<IPanelSection> Sections { get; }

        void Initialize();
        void ApplyAction(ToolActionData toolActionData);
        Task ApplyActionAsync(ToolActionData toolActionData);
        void ApplyAction(ToolSectionActionData toolSectionActionData);
        Task ApplyActionAsync(ToolSectionActionData toolSectionActionData);
        void ApplyAction(ToolConeActionData toolConeActionData);
        Task ApplyActionAsync(ToolConeActionData toolConeActionData);
    }
}
