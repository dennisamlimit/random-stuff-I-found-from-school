using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_Funktionsgleichung
{
    class main
    {
        static void Main(string[] args)
        {
            //Variablen Deklarieren mit dem Wert 0
            int m = 0;
            int b = 0;

            int Ergebnis = 0;

            //Ausgabe von Text ( \t = Tabulator, macht einen abstand, \n = Newline, erstellt eine neue "Line" ) 
            Console.WriteLine("\tBitte geben Sie für eine Funktion der Form \n\n");
            Console.WriteLine("\t\t f(x) = mx + b \n\n");

            //Der Variable m einen Wert zufügen bzw eine Größe mit der wir später rechnen können
            Console.Write("\t - die Größe m ein: ");
            m = Convert.ToInt32(Console.ReadLine());

            //Der Variable b einen Wert zufügen bzw eine Größe mit der wir später rechnen können
            Console.Write("\t - die Größe b ein: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Ohne Text zugewiesen damit wir eine neue leere Line haben
            Console.WriteLine();

            Console.Write("\tBei welchem x-Wert soll die Wertetabelle beginnen? :  ");
            int Xwertbeginn = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tBei welchem x-Wert soll die Wertetabelle enden? :  ");
            int Xwertende = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tGeben Sie jetzt noch eine Schrittweite für x ein? :  ");
            int Schrittweite = Convert.ToInt32(Console.ReadLine());

            //einfach nur eine neue Linie damit nicht alles so zusammengedrückt ist in der Console
            Console.WriteLine("");
            Console.WriteLine("");

            //ändert die schriftfarbe auf Rot
            Console.ForegroundColor = ConsoleColor.Red;
            //Tabellenkopf
            Console.WriteLine("\t\t" + "|\t" + "x" + "\t|\t" + "y" + "\t|");
            //ändert die schriftfarbe wieder auf weiß
            Console.ForegroundColor = ConsoleColor.White;

           //erhöht den Wert der Variable Xwertbeginn damit die genauso groß ist wie Xwertende
            for (Xwertbeginn = Xwertbeginn; Xwertbeginn < Xwertende; Xwertbeginn++)
            {
                //Die Variable Ergebnis ist nur da, damit wir das "Ergebnis" ausrechnen können, bzw das immer da haben
                Ergebnis = m * Xwertbeginn + b;
                Console.WriteLine("\t\t" + "|\t" + Xwertbeginn + "\t|\t" + Ergebnis + "\t|");
            }
            //ist einfach nur damit da, damit die letzte Zahl also wie im Beispielblatt 15 mitgezählt wird, weil die letzte Zahl wird nie aufgeschrieben.
            if (Xwertbeginn == Xwertende)
            {
                //Hier rechnen wir es nochmal aus damit wir auch auf die letzte Zahl kommen
                Ergebnis = m * Xwertbeginn + b;
                Console.WriteLine("\t\t" + "|\t" + Xwertbeginn + "\t|\t" + Ergebnis + "\t|");
            }

            Console.ReadKey();
        }
    }
}
