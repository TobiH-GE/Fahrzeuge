﻿using System;
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
        public new void ZeigeDaten()
        {
            (this as Auto).ZeigeDaten();
            Console.Write("Allradantrieb: {0} ", Allradantrieb);
        }
    }
}
