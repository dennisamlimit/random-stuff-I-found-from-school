using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace %PROJECT%.Funktionen
{
    public class _WriteStringFunction
    {

        public static void WriteString(string Text)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "Denni's - Writing";
                Console.Write(c);
                Thread.Sleep(random.Next(4));
            }

            Console.Title = "Denni's - Idle";
        }

        public static void WriteString_delayed(string Text, int delay)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "Denni's - Writing";
                Console.Write(c);
                Thread.Sleep(random.Next(delay));
            }

            Console.Title = "Denni's - Idle";
        }

    }
}
