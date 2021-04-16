using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ereditarieta
{
    public class Triangolo : Forma
    {
        public double Area(double altezza, double lato)
        {
            return (lato*altezza)/2;
        }

        public double Perimetro(double altezza, double lato)
        {
            return 3*lato;
        }
    }
}