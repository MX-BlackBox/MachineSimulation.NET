using MaterialRemove.Geometry.math;

namespace MaterialRemove.Geometry.Curve
{

	public interface IParametricCurve3d
	{
		bool IsClosed {get;}

		// can call SampleT in range [0,ParamLength]
		double ParamLength {get;}
		Vector3d SampleT(double t);
		Vector3d TangentT(double t);        // returns normalized vector

		bool HasArcLength {get;}
		double ArcLength {get;}
		Vector3d SampleArcLength(double a);

		void Reverse();

		IParametricCurve3d Clone();		
	}

	public interface IParametricCurve2d
	{
		bool IsClosed {get;}

		// can call SampleT in range [0,ParamLength]
		double ParamLength {get;}
		Vector2d SampleT(double t);
        Vector2d TangentT(double t);        // returns normalized vector

		bool HasArcLength {get;}
		double ArcLength {get;}
		Vector2d SampleArcLength(double a);

		void Reverse();

        bool IsTransformable { get; }
        void Transform(ITransform2 xform);

        IParametricCurve2d Clone();
	}

}
