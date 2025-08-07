using g3;
using MaterialRemove.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRemove.ViewModels.Extensions
{
    static class ToolApplicationExtension
    {
        private static Vector3d _xpos = new Vector3d(1.0, 0.0, 0.0);
        private static Vector3d _xneg = new Vector3d(-1.0, 0.0, 0.0);
        private static Vector3d _ypos = new Vector3d(0.0, 1.0, 0.0);
        private static Vector3d _yneg = new Vector3d(0.0, -1.0, 0.0);
        private static Vector3d _zpos = new Vector3d(0.0, 0.0, 1.0);
        private static Vector3d _zneg = new Vector3d(0.0, 0.0, -1.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static internal AxisAlignedBox3d GetBound(this ToolApplication toolApplication)
        {
            return ToolHelper.GetBound(toolApplication.Position,
                                        toolApplication.Radius,
                                        toolApplication.Length,
                                        toolApplication.Orientation,
                                        toolApplication.Direction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static internal Vector3d GetDirection(this ToolApplication toolApplication)
        {
            switch (toolApplication.Orientation)
            {
                case Orientation.XPos:          return _xpos;
                case Orientation.XNeg:          return _xneg;
                case Orientation.YPos:          return _ypos;
                case Orientation.YNeg:          return _yneg;
                case Orientation.ZPos:          return _zpos;
                case Orientation.ZNeg:          return _zneg;
                case Orientation.Any:           return toolApplication.Direction;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static internal Vector3d GetDirectionAndInvert(this ToolApplication toolApplication)
        {
            switch (toolApplication.Orientation)
            {
                case Orientation.XPos: return _xneg;
                case Orientation.XNeg: return _xpos;
                case Orientation.YPos: return _yneg;
                case Orientation.YNeg: return _ypos;
                case Orientation.ZPos: return _zneg;
                case Orientation.ZNeg: return _zpos;
                case Orientation.Any: return toolApplication.Direction * -1.0f;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}
