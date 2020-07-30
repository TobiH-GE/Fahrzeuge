using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Auto : Fahrzeug
    {
        protected int PS;
        
        public Auto(int PS, string Marke, int Geschwindigkeit)
        {
            this.PS = PS;
            this.Marke = Marke;
            this.Geschwindigkeit = Geschwindigkeit;
        }
        public virtual void ZeigeDaten()
        {
            Console.WriteLine("PS: {0} Startnummer: {1} Geschwindigkeit: {2}", PS, Marke, Geschwindigkeit);
        }
    }
}
