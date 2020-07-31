using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Fahrzeug
    {
        protected string Marke;
        protected string Modell;
        protected int MaxGeschwindigkeit;
        protected int Geschwindigkeit;
        protected double Gewicht;

        public virtual void ZeigeDaten()
        {

        }
        public int NeueGeschwindigkeit
        {
            get
            {
                return Geschwindigkeit;
            }
            set
            {
                Geschwindigkeit = value;
            }

        }
    }
}
