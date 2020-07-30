using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Gelaendewagen : Auto
    {
        bool Allradantrieb;
        public Gelaendewagen(int PS, string Marke, int Geschwindigkeit, bool Allradantrieb, string Modell, int MaxGeschwindigkeit, int Gewicht) : base(PS, Marke, Geschwindigkeit, Modell, MaxGeschwindigkeit, Gewicht)
        {
            this.Allradantrieb = Allradantrieb;
        }
        public override void ZeigeDaten()
        {
            Console.WriteLine("PS: {0} Marke: {1} Geschwindigkeit: {2} Allradantrieb: {3}", PS, Marke, Geschwindigkeit, Allradantrieb);
        }
    }
}
