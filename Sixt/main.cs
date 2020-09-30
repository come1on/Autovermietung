using ConsoleApp1;
using System;

namespace Sixt
{
    internal class main
    {
        private static void Main(string[] args)
        {
            const int MaxAutoAnzahl = 20;
            const int MaxKundenAnzahl = 20;

            PKW[] Autos = new PKW[MaxAutoAnzahl];
            Kunden[] Kundenakten = new Kunden[MaxKundenAnzahl];

            Autos[0] = new PKW();
            Autos[0].Bez = "BMW";
            Console.WriteLine("Bez: " + Autos[0].Bez);

            /* IDraw[] arr = new IDraw[5];

             arr[0] = new GraphicRectangle();
             arr[1] = new PKW();
             arr[2] = new GraphicRectangle();
             arr[3] = new GraphicRectangle();
             arr[4] = new PKW();

             foreach (IDraw banana in arr)
                 banana.Draw();

             StrFahrzeug p2 = (StrFahrzeug)arr[4];
             */
            short Eingabe = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("++");
                    Console.WriteLine("1. Auto anlegen");
                    Console.WriteLine("++");
                    Console.WriteLine("2. Alle Autos anzeigen");
                    Console.WriteLine("++");
                    Console.WriteLine("3. Kunden anlegen");
                    Console.WriteLine("++");
                    Console.WriteLine("4. Alle Kunden anzeigen");
                    Eingabe = short.Parse(Console.ReadLine());
                    Console.ReadLine();
                    if ((Eingabe < 0) || (Eingabe > 7))
                    {
                        throw new Exception("Bitte zwischen 0 und 7!");
                    }
                    switch (Eingabe)
                    {
                        case 1:
                            Autos[PKW.AnzahlAutos] = new PKW();

                            break;

                        case 2:
                            foreach (PKW banana in Autos)
                                banana.anzeigen();
                            break;

                        case 3:
                            Kundenakten[Kunden.AnzahlKunden] = new Kunden();
                            break;

                        case 4:
                            foreach (Kunden tomate in Kundenakten)
                                tomate.anzeigen();
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Source);
                    Console.WriteLine("Exception: " + e.Message);
                    Eingabe = 1;
                    Console.Clear();
                }
            } while (Eingabe != 0);
        }
    }
}