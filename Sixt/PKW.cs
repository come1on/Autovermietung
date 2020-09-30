using Sixt;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PKW : StrFahrzeug
    {

        short AnzahlPlaetze = 0;
        public bool verliehen = false;
        public static short AnzahlAutos = 0;

        public PKW()
        {
            AnzahlAutos++;
        }

        public void eingeben()
        {
            Console.WriteLine("biite was eingeben: ");
            Bez = Console.ReadLine();
            Console.WriteLine("Btte die PKW-Farbe eingeben: ");
            Farbe = Console.ReadLine();
            Console.WriteLine("Bite die Geschwindigkeit eingeben: ");
            Geschw = short.Parse(Console.ReadLine());
            Console.WriteLine("Anzahl Räder: ");
            AnzahlRaeder = short.Parse(Console.ReadLine());
            Console.WriteLine("Anzahl Sitzplätze: ");
            AnzahlPlaetze = short.Parse(Console.ReadLine());

        }

        public void anzeigen()
        {
            Console.WriteLine("Der PKW hat die Bezeichnung " +Bez);
            Console.WriteLine("Der PKW hat die Farbe " +Farbe);
            Console.WriteLine("Der PKW hat die Geschwindigkeit " + Geschw);
            Console.WriteLine("Der PKW hat  " + AnzahlRaeder + " Räder");
        }
    }
}
