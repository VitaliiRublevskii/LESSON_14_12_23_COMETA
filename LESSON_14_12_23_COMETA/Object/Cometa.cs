using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LESSON_14_12_23_COMETA.Mater;
using LESSON_14_12_23_COMETA.Point;

namespace LESSON_14_12_23_COMETA.Object
{
    public class Cometa : CosmosObject
    {
        public Cometa() : base() { }

        public Cometa(int iD, Point3D point3D, Vector vector, float speed, Materials[] materials, string name) : base()
        {
            ID = iD;
            Point = point3D;
            Vector = vector;
            Speed = speed;
            Name = name;
            Materials = new Materials[materials.Length];
            materials.CopyTo(Materials, 0);
        }

        public override void PrintObject()
        {
            Console.WriteLine($"   Комета {Name} (ID {ID}), скорость {Speed} km/h, начальные координаты: {Point.CoordX}:{Point.CoordY}:{Point.CoordZ},");
            Console.Write($" имеет состав:");
            {
                for (int i = 0; i < Materials.Length; i++)
                    Console.Write($" {Materials[i].GetName()} ({Materials[i].GetPersent()}%) ");
            }
            Console.WriteLine();
        }

    }
}
