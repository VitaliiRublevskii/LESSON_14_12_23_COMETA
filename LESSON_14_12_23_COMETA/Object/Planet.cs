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
            this.Core = core;
        }
    }
}
