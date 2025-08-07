using MaterialRemove.Geometry.Implicit;
using MaterialRemove.Geometry.math;
using MaterialRemove.Geometry.Mesh;
using MaterialRemove.Interfaces;
using MaterialRemove.ViewModels.Extensions;

namespace MaterialRemove.ViewModels
{
    public abstract class SectionFaceViewModel : SectionElementViewModel, ISectionFace, BoundedImplicitFunction3d
    {
        static int _seedId;

        public double SizeX { get; set; }
        public double SizeY { get; set; }
        public Orientation Orientation { get; set; }

        public SectionFaceViewModel() : base()
        {
            Id = _seedId++;
        }

        internal override DMesh3 GenerateMesh()
        {
            return MeshProcessHelper.GenerateMeshBase(
                new ImplicitNaryDifference3d() { A = this, BSet = ToolApplications },
                this.GetFilterBox(RemovalParameters.FilterMargin),
                RemovalParameters.CubeSize,
                RemovalParameters.ParallelComputing);
        }

        #region BoundedImplicitFunction3d
        public AxisAlignedBox3d Bounds() => this.GetBound();

        public double Value(ref Vector3d pt) => this.GetDistance(pt);
        #endregion
    }
}
