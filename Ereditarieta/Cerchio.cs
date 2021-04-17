using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ereditarieta
{
    public class Cerchio : Forma
    {
        public double Area(double altezza, double lato)
        {
            return Math.PI*Math.Pow(altezza, 2);
        }

        public double Area(double raggio)
        {
            return Math.PI * Math.Pow(raggio, 2);
        }

        public double Perimetro(double altezza, double lato)
        {
            
            return 2 * Math.PI * altezza;
        }

        public double Perimetro(double raggio)
        {

            return 2 * Math.PI * raggio;
        }
    }
}