using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LESSON_14_12_23_COMETA.Mater;
using LESSON_14_12_23_COMETA.Point;

namespace LESSON_14_12_23_COMETA.Object
{
    public class CosmosObject
    {
        public int ID { get; set; }
        public Point3D Point { get; set; }
        public Vector Vector { get; set; }
        public float Speed { get; set; }
        public Materials[] Materials { get; set; }
        public string Name { get; set; }

     

        public CosmosObject() { }

        public CosmosObject(int iD, Point3D point3D, Vector vector, float speed, Materials[] materials, string name)
        {
            ID = iD;
            Point = point3D;
            Vector = vector;
            Speed = speed;
            Name = name;
            Materials = new Materials[materials.Length];
            materials.CopyTo(Materials, 0);
        }

        public float GetSpeed() { return Speed; }

        public virtual void PrintObject() { }

        public virtual double FGravit(CosmosObject @object) { return 0; }


    }
}
