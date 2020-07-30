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
        public override void ZeigeDaten()
        {
            Console.WriteLine("PS: {0} Marke: {1} Geschwindigkeit: {2} ", PS, Marke, Geschwindigkeit);
        }
    }
}
