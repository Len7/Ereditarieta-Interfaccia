using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ereditarieta
{
    public class Cerchio : Forma
    {
        public double r;
        public double Area(double altezza, double lato)
        {
            return Math.PI*Math.Pow(r,2);
        }

        public double Perimetro(double altezza, double lato)
        {
            
            return 2 * Math.PI * r;
        }
    }
}