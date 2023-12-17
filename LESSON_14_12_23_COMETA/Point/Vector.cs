using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_14_12_23_COMETA.Point
{
    public class Vector
    {
        public Point3D point1 { get; set; }
        public Point3D point2 { get; set; }


        public Vector() { }
        public Vector(Point3D point1, Point3D point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public Point3D GetVector()
        {
            Point3D point = new Point3D();

            point.CoordX = point2.CoordX - point1.CoordX;
            point.CoordY = point2.CoordY - point1.CoordY;
            point.CoordZ = point2.CoordZ - point1.CoordZ;
            return point;
        }
    }
}
