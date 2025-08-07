using MaterialRemove.Geometry.math;

namespace MaterialRemove.Geometry.Queries
{
    /// <summary>
    /// returned by linear-primitive intersection functions
    /// </summary>
    public struct LinearIntersection
    {
        public bool intersects;
        public int numIntersections;       // 0, 1, or 2
        public Interval1d parameter;       // t-values along ray

        public readonly static LinearIntersection NoIntersection = new LinearIntersection() { intersects = false, numIntersections = 0 };
    }

}
