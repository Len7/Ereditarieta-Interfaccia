using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ereditarieta
{
    public class Rettangolo : Forma
    {
        public virtual double Area(double altezza, double lato)
        {
            return lato*altezza;
        }

        public virtual double Perimetro(double altezza, double lato)
        {
           return 2*(lato + altezza);
        }
    }
}