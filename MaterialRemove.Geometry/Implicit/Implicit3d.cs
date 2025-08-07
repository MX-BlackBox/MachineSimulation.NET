using MaterialRemove.Geometry.math;
using System.Collections.Generic;

namespace MaterialRemove.Geometry.Implicit
{
	/// <summary>
	/// Minimalist implicit function interface
	/// </summary>
    public interface ImplicitFunction3d
    {
        double Value(ref Vector3d pt);
    }


	/// <summary>
	/// Bounded implicit function has a bounding box within which
	/// the "interesting" part of the function is contained 
	/// (eg the surface)
	/// </summary>
	public interface BoundedImplicitFunction3d : ImplicitFunction3d
	{
		AxisAlignedBox3d Bounds();
	}


	/// <summary>
	/// Implicit sphere, where zero isocontour is at Radius
	/// </summary>
	public class ImplicitSphere3d : BoundedImplicitFunction3d
    {
		public Vector3d Origin;
		public double Radius;

        public double Value(ref Vector3d pt)
        {
			return pt.Distance(ref Origin) - Radius;
        }

		public AxisAlignedBox3d Bounds()
		{
			return new AxisAlignedBox3d(Origin, Radius);
		}
    }

    /// <summary>
    /// Boolean Difference of N implicit functions, A - Union(B1..BN)
    /// Assumption is that both have surface at zero isocontour and 
    /// negative is inside.
    /// </summary>
    public class ImplicitNaryDifference3d : BoundedImplicitFunction3d
	{
		public BoundedImplicitFunction3d A;
		public List<BoundedImplicitFunction3d> BSet;

		public double Value(ref Vector3d pt)
		{
            double fA = A.Value(ref pt);

#if DEBUG
            if (BSet.Count == 0) return fA;
            var bset = BSet.ToArray();
            if ((bset.Length == 0) || bset[0] == null) return fA;
            double fB = bset[0].Value(ref pt);
            for (int k = 1; k < bset.Length; ++k)
            {
                if (bset[k] == null) break;
                fB = System.Math.Min(fB, bset[k].Value(ref pt));
            }
            return System.Math.Max(fA, -fB);
#else
            if (BSet.Count == 0)
                return fA;
            double fB = BSet[0].Value(ref pt);
            for (int k = 1; k < BSet.Count; ++k)
                fB = System.Math.Min(fB, BSet[k].Value(ref pt));
            return System.Math.Max(fA, -fB);
#endif
        }

        public AxisAlignedBox3d Bounds()
		{
			// [TODO] could actually subtract other bounds here...
			return A.Bounds();
		}
	}

}
