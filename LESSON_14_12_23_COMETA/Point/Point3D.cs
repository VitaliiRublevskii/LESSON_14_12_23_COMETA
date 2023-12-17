using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_14_12_23_COMETA.Point
{
    public class Point3D
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public int CoordZ { get; set; }

        public Point3D() { }
        public Point3D(int coordX, int coordY, int coordZ)
        {
            CoordX = coordX;
            CoordY = coordY;
            CoordZ = coordZ;
        }

        public void PrintPoint3D()
        {
            Console.Write($"{CoordX}:{CoordY}:{CoordZ}");
        }
    }
}
