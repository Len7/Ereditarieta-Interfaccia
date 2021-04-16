using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ereditarieta
{
    public partial class Input : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* Rettangolo sacro = new Rettangolo();
            //sacro.Area(1.2,1.2);

            sal.Value= sacro.Area( Convert.ToDouble(Raggio.Text), Convert.ToDouble(Altezza.Text)).ToString();
           */

        }

        protected void Cerchio_Click(object sender, EventArgs e)
        {
            Cerchio cerchio = new Cerchio();
            cerchio.r = Convert.ToDouble(Raggio.Text);

            double a = cerchio.r;

            Visualliza1.Text = "Area del cerchio " + cerchio.Area(a, Convert.ToDouble(Lato.Text));
            Visualliza2.Text = "Perimetro del cerchio " + cerchio.Perimetro(a, Convert.ToDouble(Lato.Text));
        }

        protected void Rettangolo_Click(object sender, EventArgs e)
        {
            Rettangolo rettangolo = new Rettangolo();
            
            Visualliza1.Text = "Area del rettangolo "+ rettangolo.Area(Convert.ToDouble(Altezza.Text), Convert.ToDouble(Lato.Text));
            Visualliza2.Text = "Perimetro del rettangolo " + rettangolo.Perimetro(Convert.ToDouble(Altezza.Text), Convert.ToDouble(Lato.Text));
        }

        protected void Quadrato_Click(object sender, EventArgs e)
        {
            Quadrato quadrato = new Quadrato();

            Visualliza1.Text = "Area del quadrato " + quadrato.Area(Convert.ToDouble(Altezza.Text), Convert.ToDouble(Lato.Text));
            Visualliza2.Text = "Perimetro del quadrato " + quadrato.Perimetro(Convert.ToDouble(Altezza.Text), Convert.ToDouble(Lato.Text));
        }

        protected void Triangolo_Click(object sender, EventArgs e)
        {
            Triangolo triangolo = new Triangolo();

            Visualliza1.Text = "Area del triangolo " + triangolo.Area(Convert.ToDouble(Altezza.Text), Convert.ToDouble(Lato.Text));
            Visualliza2.Text = "Perimetro del triangolo " + triangolo.Perimetro(Convert.ToDouble(Altezza.Text), Convert.ToDouble(Lato.Text));
        }
    }
}