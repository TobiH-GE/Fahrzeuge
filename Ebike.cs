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
        public virtual void ZeigeDaten()
        {
            Console.WriteLine("Reichweite: {0} Marke: {1} Geschwindigkeit: {2} MarkeMotor: {3}", Reichweite, Marke, Geschwindigkeit, MarkeMotor);
        }
    }
}
