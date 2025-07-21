using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_Statistik
{
    class Program
    {
        public static void Main(string[] args)
        {


            //Int
            double Number1;
            int Number2 = 0;
            int Number3;
            int Number4 = 0;

            Console.Title = "Schule | Statistik EA19A";

            //Eingabe der Zahlen
            Console.WriteLine("\t         S t a t i s t i k");
            Console.Write("\t         ----------------- ");
            Console.Write("\n\tWieviele Werte wollen Sie eingeben: ");
            Number1 = Convert.ToInt32(Console.ReadLine());

            //Ausgabe der Zahlen
            for (int i = 1; i < Number1 + 1; i++)
            {
                Console.Write("\tBitte");

                Console.Write(" {0}. ", i);
                Console.Write("Zahl eingeben : ");
                Number2 = Convert.ToInt32(Console.ReadLine());

                Number4 += Number2;

            }
            Console.Write("\n\tSumme der Zahlen       =  " + Number4);
            Console.Write("\n\tMittelwert der Zahlen  =    " + Number4/Number1);
            Console.ReadKey();
        }
    }
}
