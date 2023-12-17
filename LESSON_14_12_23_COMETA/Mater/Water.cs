using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_14_12_23_COMETA.Mater
{
    public class Water : Materials
    {
        public Water() { }

        public Water(float persent) : base("Water", persent)
        {
            Name = "Water";
            Persent = persent;
        }

        public string GetName() { return Name; }
        public float GetPersent() { return Persent; }

    }
}
