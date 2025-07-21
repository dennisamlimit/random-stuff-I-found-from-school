using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_Fakultät
{
    class main
    {
        static void Main(string[] args)
        {
            int Eingabe = 1;
            //Das Ergebnis was in der Schleife ausgerechnet wird
            int Ergebnis = 1;


            Console.WriteLine("\tProgramm zur Berechnung der Fakultaet einer Zahl");
            Console.WriteLine("\t------------------------------------------------");
            Console.Write("\n\tGeben Sie die Zahl <Zahl <= 10> (kleiner als 10) ein, deren Fakltaet \n\tberechnet werden soll: ");

            //Die Eingabe für unsere Zahl, bzw unseren Wert
            Eingabe = Convert.ToInt32(Console.ReadLine());

            // int i deklarieren mit dem Wert 1;; wenn i kleiner gleich Eingabe ist dann wird i + 1 gerechnet, damit i genau denselben Wert hat wie Eingabe und das führt dazu das wir das richtige Ergebnis bekommen
            for (int i = 1; i <= Eingabe; i++)
            {
                // Ergebnis mal gleich i
                Ergebnis *= i;
            }
            // Ausgabe der Werte
            Console.WriteLine("\n\n\tFakultaet der Zahl " + Eingabe + " = " + Ergebnis);

            Console.ReadKey();
        }
    }
}
