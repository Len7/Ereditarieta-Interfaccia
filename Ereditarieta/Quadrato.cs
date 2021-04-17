using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ereditarieta
{
    public class Quadrato: Rettangolo
    {
        public override double Area(double altezza, double lato)
        {
            return Math.Pow(lato,2);
        }

        public override double Perimetro(double altezza, double lato)
        {
            return lato * 4;
        }
    }
}