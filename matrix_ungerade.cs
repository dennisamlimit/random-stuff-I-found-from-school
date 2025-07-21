using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lösungen_Matrix_Spaltensumme.Lösungen
{
    public class Lösung_Matrix_Ungerade
    {
        public static void Lösung_Matrix_Ungerade_Main()
        {
            int[,] matrix = new int[4, 4];

            Console.Write("\nProgramm zur Ermittlung von geraden Zahlen in einer 4 x 4 Matrix\n----------------------------------------------------------------\n\nGeben Sie eine 4 x 4 Matrix ein:\n\n");

            for (int i = 0; i < 4; i++) { for (int j = 0; j < 4; j++) { matrix[i, j] = Convert.ToInt32(Console.ReadLine()); } }

            Console.Write("\nGerade Zahlen der Matrix: ");

            for (int i = 0; i < 4; i++) { for (int j = 0; j < 4; j++) { if (matrix[i, j] % 2 != 0) { Console.Write(matrix[i, j] + " "); } }}
            Console.ReadKey();
        }
    }
}
