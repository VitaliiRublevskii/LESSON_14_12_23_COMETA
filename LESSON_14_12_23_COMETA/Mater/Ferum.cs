using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LESSON_14_12_23_COMETA.Mater
{
    public class Ferum : Materials
    {
        public Ferum() { }

        public Ferum(float persent) : base("Ferum", persent)
        {
            Name = "Ferum";
            Persent = persent;
        }

        public string GetName() { return Name; }
        public float GetPersent() { return Persent; }
    }
}
