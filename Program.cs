using System;

namespace Fahrzeuge
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Fahrzeug1 = new Auto(50, "BMW", 130);
            Gelaendewagen Fahrzeug2 = new Gelaendewagen(80, "Jeep", 100, true);
            Ebike Fahrzeug3 = new Ebike(250, 100, "Bosch", "Shimano", 8, "Focus", "X-100", 0, 25, 20);

            Fahrzeug1.ZeigeDaten();
            Fahrzeug2.ZeigeDaten();
            Fahrzeug3.ZeigeDaten();

            Fahrzeug1.NeueGeschindigkeit = 20;
            Fahrzeug2.NeueGeschindigkeit = 50;

            Fahrzeug1.ZeigeDaten();
            Fahrzeug2.ZeigeDaten();
            Fahrzeug3.ZeigeDaten();
            Console.ReadKey();
        }
    }
}
