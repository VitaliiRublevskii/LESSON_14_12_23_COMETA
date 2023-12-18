using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LESSON_14_12_23_COMETA.Mater;
using LESSON_14_12_23_COMETA.Point;

namespace LESSON_14_12_23_COMETA.Object
{
    public class Planet : CosmosObject
    {
        public Core Core { get; set; }
        public Planet() { }

        public Planet (int iD, Point3D point3D, Vector vector, float speed, Materials[] materials, string name, Core core) : base()
        {
            this.ID = iD;
            this.Point = point3D;
            this.Vector = vector;
            this.Speed = speed;
            this.Materials = materials;
            this.Name = name;
            this.Core = core;
        }

        


        public override void PrintObject()
        {
            Console.WriteLine($"   Планета {Name} (ID {ID}), скорость {Speed} km/h, начальные координаты: {Point.CoordX}:{Point.CoordY}:{Point.CoordZ},");
            Console.Write($" температура ядра планеты {Core.Temp}, радиус ядра {Core.Radius}, имеет состав:");
            {
                for (int i = 0; i < Materials.Length; i++)
                    Console.Write($" {Materials[i].GetName()} ({Materials[i].GetPersent()}%) ");
            }
            Console.WriteLine();
        }

        public override double FGravit(CosmosObject @object) 
        {
            double F = 0, G = 0, M = 0, m = 0, R = 0; // сила гравитации

            F = G * ((M * m) / (R * R));
            return F;
        }
    }
}
