using Machine.Views.ViewModels;
using System;

namespace Machine.Views.Messages
{
    class GetPanelDataMessage
    {
        public Action<PanelData> SetPanelData { get; set; }
    }
}
