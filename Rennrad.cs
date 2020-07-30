using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Rennrad : Fahrrad
    {
        public Rennrad(string Marke, string Modell, int Geschwindigkeit, int MaxGeschwindigkeit, int Gewicht, int Gaenge, string HerstellerSchaltung) : base(Marke, Modell, Geschwindigkeit, MaxGeschwindigkeit, Gewicht, Gaenge, HerstellerSchaltung)
        {

        }
    }
}
