using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierarbeit_lösungen
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe;
            double Volt;
            double Ohm;

            Start:
            Console.Write("\tProgramm zur Berechnung der Leistung\n\toder der Stromstärke in einem Stromkreis");
            Console.Write("\n\t-----------------------------------------\n");
            Console.Write("\tGeben Sie eine 1 für die Leistungsberechnung\n\toder eine 2 für die Stromberechnung ein: ");
            Eingabe = Convert.ToString(Console.ReadLine());

            if (Eingabe == "1")
            {
                Console.Write("\n\n");
                Console.Write("\tGeben Sie die Spannung in <Volt> ein : ");
                Volt = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("\tGeben Sie den Widerstandswert in <Ohm> ein : ");
                Ohm = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("\tDie Leistung beträgt " + Volt * Volt / Ohm + " Watt.");
            }
            else if (Eingabe == "2")
            {
                Console.Write("\n\n");
                Console.Write("\tGeben Sie die Spannung in <Volt> ein : ");
                Volt = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("\tGeben Sie den Widerstandswert in <Ohm> ein : ");
                Ohm = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("\tDie Stromstärke beträgt " + Volt/Ohm + " Ampere.");
            }
            else
            {
                Console.Write("\n\n");
                Console.Write("\tGeben Sie entweder eine <1> oder eine <2> ein, sonst ist Ihr Befehl ungültig!");
            }
            Console.ReadKey();
            Console.Clear();
            goto Start;



        }
    }
}
