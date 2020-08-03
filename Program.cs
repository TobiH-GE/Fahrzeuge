﻿using System;
using System.Collections.Generic;

namespace Fahrzeuge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fahrzeug> AlleFahrzeuge = new List<Fahrzeug>()
            {
                new PKW(50, "BMW", 130, "i3", 270, 2000),
                new Gelaendewagen(80, "Jeep", 100, true, "Offroad1", 220, 2500),
                new Ebike(250, 100, "Bosch", "Shimano", 8, "Focus", "X-100", 0, 25, 20),
                new Omnibus()
            };

            foreach(Fahrzeug EinFahrzeug in AlleFahrzeuge)
            {
                EinFahrzeug.ZeigeDaten();
            }

            AlleFahrzeuge[0].NeueGeschwindigkeit = 20;
            AlleFahrzeuge[1].NeueGeschwindigkeit = 30;

            foreach (Fahrzeug EinFahrzeug in AlleFahrzeuge)
            {
                EinFahrzeug.ZeigeDaten();
            }

            Console.ReadKey();
        }
    }
}
