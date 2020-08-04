using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Fahrrad : Fahrzeug
    {
        protected int Gaenge;
        protected string HerstellerSchaltung;
        public Fahrrad(string Marke, string Modell, int Geschwindigkeit, int MaxGeschwindigkeit, int Gewicht, int Gaenge, string HerstellerSchaltung)
        {

        }
        public new void ZeigeDaten()
        {
            (this as Fahrzeug).ZeigeDaten();
            Console.Write("Gaenge: {0} HerstellerSchaltung: {1} ", Gaenge, HerstellerSchaltung);
        }
    }
}
