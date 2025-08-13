using Machine.ViewModels.Interfaces.Probing;

namespace Machine.ViewModels.Probing
{
    public class PointProbeViewModel : BaseProbeViewModel, IProbe, IProbePoint
    {
        #region IProbe
        public int ProbeId { get; set; }

        private double _x;
        public double X 
        { 
            get => _x; 
            set => Set(ref _x, value, nameof(X)); 
        }

        private double _y;
        public double Y
        {
            get => _y;
            set => Set(ref _y, value, nameof(Y));
        }

        private double _z;
        public double Z
        {
            get => _z;
            set => Set(ref _z, value, nameof(Z));
        }
        #endregion

        #region IProbePoint
        public double RelativeX { get; set; }
        public double RelativeY { get; set; }
        public double RelativeZ { get; set; }
        #endregion
    }
}
