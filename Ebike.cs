using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Ebike : Fahrrad
    {
        int WattstundenAkku;
        int Reichweite;
        string MarkeMotor;

        public Ebike(int WattstundenAkku, int Reichweite, string MarkeMotor, string HerstellerSchaltung, int Gaenge, string Marke, string Modell, int Geschwindigkeit, int MaxGeschwindigkeit, int Gewicht) : base(Marke, Modell, Geschwindigkeit, MaxGeschwindigkeit, Gewicht, Gaenge, HerstellerSchaltung)
        {
            this.WattstundenAkku = WattstundenAkku;
            this.Reichweite = Reichweite;
            this.MarkeMotor = MarkeMotor;
            this.HerstellerSchaltung = HerstellerSchaltung;
            this.Gaenge = Gaenge;
            this.Marke = Marke;
            this.Modell = Modell;
            this.Geschwindigkeit = Geschwindigkeit;
            this.MaxGeschwindigkeit = MaxGeschwindigkeit;
            this.Gewicht = Gewicht;
        }
        public new void ZeigeDaten()
        {
            (this as Fahrzeug).ZeigeDaten();
            Console.WriteLine("WattstundenAkku: {0} Reichweite: {1} MarkeMotor: {2}\n", WattstundenAkku, Reichweite, MarkeMotor);
        }
    }
}
