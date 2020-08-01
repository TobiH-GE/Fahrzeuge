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
        public new void ZeigeDaten()
        {
            (this as Fahrzeug).ZeigeDaten();
            Console.Write("PS: {0} ", PS);
        }
    }
}
