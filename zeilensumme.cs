using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lösungen_Matrix_Spaltensumme.Lösungen
{
    public class Lösung_Zeilensumme
    {
        public static void Zeilensumme_Main()
        {
            int[,] matrix = new int[3, 3];
            int[] ergebnisse = new int[3];

            Console.Write("\n\n\tProgramm zur Berechnung der Zeilensummen\n\t\teiner 3 x 3 Matrix\n\t----------------------------------------\n\tGeben Sie eine 3x3 Matrix ein:\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == 0) { ergebnisse[i] += matrix[i, j]; }
                    else if (i == 1) { ergebnisse[i] += matrix[i, j]; }
                    else if (i == 2) { ergebnisse[i] += matrix[i, j]; }
                }
            }
            Console.Write("\n");
            Console.Write("Die Summe der nullten Zeile = " + ergebnisse[0] + "\n");
            Console.Write("Die Summe der ersten Zeile = " + ergebnisse[1] + "\n");
            Console.Write("Die Summe der zweiten Zeile = " + ergebnisse[2] + "\n");
            Console.ReadKey();
        }
    }
}
