using System;

namespace Fahrzeuge
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] AlleFahrzeuge = new dynamic[10];

            AlleFahrzeuge[0] = new Auto(50, "BMW", 130, "i3", 270, 2000);
            AlleFahrzeuge[1] = new Gelaendewagen(80, "Jeep", 100, true, "Offroad1", 220, 2500);
            AlleFahrzeuge[2] = new Ebike(250, 100, "Bosch", "Shimano", 8, "Focus", "X-100", 0, 25, 20);

            AlleFahrzeuge[0].ZeigeDaten();
            AlleFahrzeuge[1].ZeigeDaten();
            AlleFahrzeuge[2].ZeigeDaten();

            AlleFahrzeuge[0].NeueGeschwindigkeit = 20;
            AlleFahrzeuge[1].NeueGeschwindigkeit = 30;

            AlleFahrzeuge[0].ZeigeDaten();
            AlleFahrzeuge[1].ZeigeDaten();
            AlleFahrzeuge[2].ZeigeDaten();

            Console.ReadKey();
        }
    }
}
