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

        public void ZeigeDaten()
        {
            Console.Write("\n\nTyp: {0} Marke: {1} Modell: {2} MaxGesch: {3} Geschwindigkeit: {4} Gewicht {5} ", this.GetType().Name, Marke, Modell, MaxGeschwindigkeit, Geschwindigkeit, Gewicht);
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
