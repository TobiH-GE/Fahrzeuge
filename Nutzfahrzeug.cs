using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeuge
{
    class Nutzfahrzeug : Fahrzeug
    {
        bool MitAnhaenger;
        public new void ZeigeDaten()
        {
            (this as Fahrzeug).ZeigeDaten();
            Console.Write("MitAnhaenger: {0} ", MitAnhaenger);
        }
    }
}
