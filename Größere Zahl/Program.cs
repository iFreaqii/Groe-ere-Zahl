using System;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Es sollen zwei beliebige Zahlen eingelesen werden können und anschließend die größere der beiden ermittelt und auf dem Bildschirm ausgegeben werden.
/// </summary>

namespace Größere_Zahl
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1 = 0;
            double zahl2 = 0;
            double ergebnis;
            string weitermachen = "";

            do
            {
                Console.WriteLine("\nBitte geben Sie die zwei beliebige Zahlen ein, aus denen die größere der beiden ermittelt werden soll.");

                zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ihre erste Zahl lautet: {0}", zahl1);

                zahl2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ihre zweite Zahl lautet: {0}", zahl2);

                if (zahl1 > zahl2)
                {
                    ergebnis = zahl1;
                }
                else if (zahl2 > zahl1)
                {
                    ergebnis = zahl2;
                }
                else
                {
                    ergebnis = zahl1;
                    Console.WriteLine("Die Zahlen sind gleich groß, wähle den ersten für die Ergebnisausgabe.");
                }

                Console.WriteLine("\nAus den beiden Werten ist {0} die größere Zahl.", ergebnis);

                Console.WriteLine("\nGeben Sie bitte (j) ein, um weitere Zahlen zu ermitteln!");
                weitermachen = Console.ReadLine();
            }
            while (weitermachen != "n");
        }
    }
}
