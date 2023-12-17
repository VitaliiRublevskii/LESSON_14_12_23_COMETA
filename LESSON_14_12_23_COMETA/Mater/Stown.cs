using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_14_12_23_COMETA.Mater
{
    public class Stown : Materials
    {
        public Stown() { }

        public Stown(float persent) : base("Stone", persent)
        {
            Name = "Stone";
            Persent = persent;
        }

        public string GetName() { return Name; }
        public float GetPersent() { return Persent; }

    }
}
