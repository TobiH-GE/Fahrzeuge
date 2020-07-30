using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Auto : Fahrzeug
    {
        protected int PS;
        
        public Auto(int PS, string Marke, int Geschwindigkeit, string Modell, int MaxGeschwindigkeit, int Gewicht)
        {
            this.PS = PS;
            this.Marke = Marke;
            this.Geschwindigkeit = Geschwindigkeit;
            this.Modell = Modell;
            this.MaxGeschwindigkeit = MaxGeschwindigkeit;
            this.Gewicht = Gewicht;
        }
        public virtual void ZeigeDaten()
        {
            Console.WriteLine("PS: {0} Marke: {1} Geschwindigkeit: {2} Modell: {3} MaxGeschwindigkeit: {4} Gewicht: {5}", PS, Marke, Geschwindigkeit, Modell, MaxGeschwindigkeit, Gewicht);
        }
    }
}
