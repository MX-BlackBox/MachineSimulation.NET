using Machine.Data.Interfaces.Tools;

namespace Machine.Views.Messages.ToolsEditor
{
    public class ToolSelectionChangedMessage
    {
        public ITool Tool { get; set; }
    }
}
