using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class PKW : Auto
    {
        int MaxPersonen;
        public PKW(int PS, string Marke, int Geschwindigkeit, string Modell, int MaxGeschwindigkeit, int Gewicht) : base(PS, Marke, Geschwindigkeit, Modell, MaxGeschwindigkeit, Gewicht)
        {
            
        }
        public new void ZeigeDaten()
        {
            (this as Auto).ZeigeDaten();
            Console.Write("MaxPersonen: {0} ", MaxPersonen);
        }
    }
}
