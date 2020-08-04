using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Omnibus : Nutzfahrzeug
    {
        String Typ; // Nahverkehr, Reisebus
        int MaxPersonBefoerderbar;
        public Omnibus()
        {

        }
        public new void ZeigeDaten()
        {
            (this as Nutzfahrzeug).ZeigeDaten();
            Console.Write("MaxPersonBefoerderbar: {0} ", MaxPersonBefoerderbar);
        }
    }
}
