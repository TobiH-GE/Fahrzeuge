using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class LKW : Nutzfahrzeug
    {
        int MaxBeladung;
        public new void ZeigeDaten()
        {
            (this as Nutzfahrzeug).ZeigeDaten();
            Console.Write("MaxBeladung: {0} ", MaxBeladung);
        }
    }
}
