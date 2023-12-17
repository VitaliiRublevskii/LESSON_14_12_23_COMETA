using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_14_12_23_COMETA.Mater
{
    public class Materials
    {
        public string Name { get; set; }
        public float Persent { get; set; }


        public Materials() { }
        public Materials(string name, float persent)
        {
            Name = name;
            Persent = persent;
        }

        public string GetName() { return Name; }
        public float GetPersent() { return Persent; }



    }
}
