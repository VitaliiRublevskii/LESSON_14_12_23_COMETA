using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LESSON_14_12_23_COMETA.Mater;

namespace LESSON_14_12_23_COMETA
{
    public class Core
    { 
        public double Temp {  get; set; }
        public double Radius { get; set; }
        

        public Core() { }
        public Core(double temp, double radius)
        {
            this.Temp = temp;
            this.Radius = radius;
            
        }




    }
}
