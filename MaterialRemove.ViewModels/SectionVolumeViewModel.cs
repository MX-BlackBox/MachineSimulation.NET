using MaterialRemove.Geometry.Implicit;
using MaterialRemove.Geometry.math;
using MaterialRemove.Geometry.Mesh;
using MaterialRemove.Interfaces;
using MaterialRemove.ViewModels.Extensions;

namespace MaterialRemove.ViewModels
{
    public abstract class SectionVolumeViewModel : SectionElementViewModel, ISectionVolume, BoundedImplicitFunction3d
    {
        static int _seedId;

        public double SizeX { get; set; }
        public double SizeY { get; set; }
        public double SizeZ { get; set; }

        public SectionVolumeViewModel() : base()
        {
            Id = _seedId++;
        }

        internal override DMesh3 GenerateMesh()
        {
            return MeshProcessHelper.GenerateMeshBase(
                new ImplicitNaryDifference3d() { A = this, BSet = ToolApplications },
                GetDecreaseBound(RemovalParameters.FilterMargin),
                RemovalParameters.CubeSize,
                RemovalParameters.ParallelComputing);
        }

        private AxisAlignedBox3d GetExpandedBound(double radius)
        {
            var box = this.GetBound();
            box.Expand(radius);
            return box;
        }

        private AxisAlignedBox3d GetDecreaseBound(double radius)
        {
            var box = this.GetBound();
            var v = new Vector3d(radius, radius, radius);

            box.Min += v;
            box.Max -= v;

            return box;
        }

        #region BoundedImplicitFunction3d
        public AxisAlignedBox3d Bounds() => this.GetBound();

        public double Value(ref Vector3d pt) => GetExpandedBound(RemovalParameters.CubeSize * 2.0).SignedDistance(pt);
        #endregion
    }
}
