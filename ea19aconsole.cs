using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EveryShitThatWeMakeInSchool
{
    class Program
    {


        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        public static void WriteString_Rainbow(string Text)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "EA19A  - Writing smth";
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.Write(c);
                Thread.Sleep(random.Next(10));
            }
            Console.Title = "EA19A  - idle";
        }

        public static void WriteString(string Text)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "EA19A  - Writing smth";
                Console.Write(c);
                Thread.Sleep(random.Next(10));
            }
            Console.Title = "EA19A  - Idle";
        }

        public static void WriteString_Delayed(string Text, int Delay)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "EA19A  - Writing smth";
                Console.Write(c);
                Thread.Sleep(random.Next(Delay));
            }
            Console.Title = "EA19A  - Idle";
        }


        static void Main()
        {
            bool _id1 = true;

            while (_id1 == true)
            {

                int input = 0;

                Console.Title = "EA19A - Idle";
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.Write("\t\t\t\t\t"); WriteString(@"___________   _____  ____ ________  _____   "); Console.WriteLine();
                Console.Write("\t\t\t\t\t"); WriteString(@"\_   _____/  /  _  \/_   /   __   \/  _  \  "); Console.WriteLine();
                Console.Write("\t\t\t\t\t"); WriteString(@" |    __)_  /  /_\  \|   \____    /  /_\  \ "); Console.WriteLine();
                Console.Write("\t\t\t\t\t"); WriteString(@" |        \/    |    \   |  /    /    |    \"); Console.WriteLine();
                Console.Write("\t\t\t\t\t"); WriteString(@"/_______  /\____|__  /___| /____/\____|__  /"); Console.WriteLine();
                Console.Write("\t\t\t\t\t"); WriteString(@"        \/         \/                    \/ "); Console.WriteLine();


                Console.WriteLine(); Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White; Console.Write("\t\t\t\t      "); WriteString("Willkommen zur EA19A Konsole");
                Console.WriteLine();
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed;  WriteString("1.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Quaderberechnung");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("2.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Ausgabe von 'Hallo Welt'");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("3.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Volumenberechnung Quader & Zylinder");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("4.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Berechnung von Leistung & Stromstaerke (1. Klassenarbeit)");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("5.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Umsatzstatistik (2. Klassenarbeit)");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("6.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Wertetabelle einer linearen Funktion");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("7.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Ermittlung eines Schaltjahres");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("8.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Statistik");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("9.   "); Console.ForegroundColor = ConsoleColor.White; WriteString("Zufallszahlen (Arrays)");
                Console.Write("\t\n   "); Console.ForegroundColor = ConsoleColor.DarkRed; WriteString("10.  "); Console.ForegroundColor = ConsoleColor.White; WriteString("2. Klassenarbeit mit Arrays");
                Console.WriteLine("\n"); Console.ForegroundColor = ConsoleColor.White; Console.Write("\tWelches Programm möchten Sie ausführen? : "); Console.ForegroundColor = ConsoleColor.DarkRed; 
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input == 1) Quaderberechnung();
                    else if (input == 2) HalloWeltAusgabe();
                    else if (input == 3) VolumenberechnungQuaderZylinder();
                    else if (input == 4) LeistungStromstaerke();
                    else if (input == 5) Umsatzstatistik();
                    else if (input == 6) Zählerschleifen();
                    else if (input == 7) Schaltjahr();
                    else if (input == 8) Statistik();
                    else if (input == 9) Zufallszahlen();
                    else if (input == 10) UmsatzstatistikMitArrays();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(""); WriteString("\t\t\t\t         Geben Sie eine Zahl zwischen 1 und 6 an!"); Console.ReadKey(); Console.Clear();
                    }             
                }  
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(""); WriteString("\t\t\t\t         Geben Sie eine Zahl zwischen 1 und 6 an!"); Console.ReadKey(); Console.Clear();
                }

            }
        }

        public static void Quaderberechnung()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            double höhe = 0;
            double breite = 0;
            double länge = 0;
            double volumen = 0;
            Console.WriteLine("\n\tProgramm zur Volumenberechnung eines Quaders");
            Console.WriteLine("\n\t-----------------------------------------------------------");
            Console.Write("\n\tBitte geben Sie die Höhe <in Meter> des Quaders ein:    ");
            höhe = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tBitte geben Sie die Breite <in Meter> des Quaders ein:  ");
            breite = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tBitte geben Sie die Länge <in Meter> des Quaders ein:   ");
            länge = Convert.ToDouble(Console.ReadLine());
            volumen = höhe * breite * länge;
            Console.WriteLine("\n\tDas Volumen des Quaders beträgt " + volumen + " Kubikmeter");
            Console.WriteLine("\n\t-----------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void HalloWeltAusgabe()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            int zähler = 0;
            Console.Write("\nWie oft soll 'Hallo Welt' ausgegeben werden? ");
            zähler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= zähler; i++)
            {
                Console.WriteLine(i + "\tHallo Welt");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void VolumenberechnungQuaderZylinder()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            int eingabe = 0;
            Console.WriteLine("\n\n\tProgramm zur Berechnung eines Quaders oder eines Zylinders");
            Console.WriteLine("\n\t**********************************************************");
            Console.WriteLine("\n\tWelches Volumen soll berechnet werden?");
            Console.WriteLine("\n\tBerechnung Quadervolumen > 1 <");
            Console.WriteLine("\n\tBerechnung Zylindervolumen > 2 <");
            Console.Write("\n\tIhre Wahl: ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t**********************************************************");
            if (eingabe == 1)
            {
                double höhe = 0;
                double breite = 0;
                double länge = 0;
                double volumen = 0;
                Console.Write("\n\tBitte geben Sie die Höhe <in Meter> des Quaders ein:    ");
                höhe = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tBitte geben Sie die Breite <in Meter> des Quaders ein:  ");
                breite = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tBitte geben Sie die Länge <in Meter> des Quaders ein:   ");
                länge = Convert.ToDouble(Console.ReadLine());
                volumen = höhe * breite * länge;
                Console.WriteLine("\n\tDas Volumen des Quaders beträgt " + volumen + " Kubikmeter");
                Console.WriteLine("\n\t**********************************************************");
            }
            else if (eingabe == 2)
            {
                double höhe = 0;
                double durchmesser = 0;
                double volumen = 0;
                Console.Write("\n\tBitte geben Sie die Höhe des Zylinders <in Meter> ein:    ");
                höhe = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tBitte geben Sie den Durchmesser des Zylinders <in Meter> ein:   ");
                durchmesser = Convert.ToDouble(Console.ReadLine());
                volumen = Math.PI * (durchmesser / 2) * (durchmesser / 2) * höhe;
                Console.WriteLine("\n\tDas Volumen des Zylinders beträgt " + volumen + " Kubikmeter");
                Console.WriteLine("\n\t**********************************************************");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void LeistungStromstaerke()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            int eingabe = 0;
            double spannung = 0;
            double widerstand = 0;
            double leistung = 0;
            double stromstaerke = 0;
            Console.WriteLine("\n\tProgramm zur Berechnung der Leistung oder \n\tder Stromstärke in einem Stromkreis");
            Console.WriteLine("\t------------------------------------------------------");
            Console.Write("\tGeben Sie eine 1 fuer die Leistungsberechnung \n\toder eine 2 fuer die Stromberechnung ein: ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            if (eingabe == 1)
            {
                Console.Write("\n\n\tGeben Sie die Spannung in <Volt> ein: ");
                spannung = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tGeben Sie den Widerstandswert in <Ohm> ein: ");
                widerstand = Convert.ToDouble(Console.ReadLine());
                leistung = (spannung * spannung) / widerstand;
                Console.WriteLine("\n\n\tDie Leistung beträgt " + leistung + " Watt.");
            }
            else if (eingabe == 2)
            {
                Console.Write("\n\n\tGeben Sie die Spannung in <Volt> ein: ");
                spannung = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tGeben Sie den Widerstandswert in <Ohm> ein: ");
                widerstand = Convert.ToDouble(Console.ReadLine());
                stromstaerke = spannung / widerstand;
                Console.WriteLine("\n\n\tDie Stromstaerke beträgt " + stromstaerke + " Ampere.");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void Umsatzstatistik()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            double tagesumsatz = 0;
            double gesamtumsatz = 0;
            double durchschnittlicherumsatz = 0;
            double minumsatz = double.MaxValue;
            double maxumsatz = 0;
            double mintag = 0;
            double maxtag = 0;
            Console.WriteLine("\t\t\t***** Umsatzstatistik *****");
            Console.WriteLine("\nBitte geben Sie die Tagesumsaetze der letzten Woche der Reihe nach ein.\n\n");
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("\tTag " + i + ": ");
                tagesumsatz = Convert.ToDouble(Console.ReadLine());
                if (minumsatz >= tagesumsatz)
                {
                    minumsatz = tagesumsatz;
                    mintag = i;
                }
                if (maxumsatz <= tagesumsatz)
                {
                    maxumsatz = tagesumsatz;
                    maxtag = i;
                }
                gesamtumsatz += tagesumsatz;
            }
            Console.WriteLine("\n\nDer Gesamtumsatz der letzten Woche betraegt:     " + gesamtumsatz + " Euro");
            durchschnittlicherumsatz = gesamtumsatz / 7;
            Console.WriteLine("Der mittlere Umsatz der letzten Woche betraegt:   " + durchschnittlicherumsatz + " Euro");
            Console.WriteLine("\nDer hoechste Umsatz wurde mit " + maxumsatz + " Euro am " + maxtag + ".Tag der Woche erzielt.");
            Console.WriteLine("Der geringste Umsatz wurde mit " + minumsatz + " Euro am " + mintag + ".Tag der Woche erzielt.");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void Zählerschleifen()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            int m = 0;
            int b = 0;
            int y = 0;
            int anfangx = 0;
            int endex = 0;
            int schrittweite = 0;
            Console.WriteLine("\n\n   ************************************************************************");
            Console.WriteLine("   *** Programm zur Berechnung der Wertetabelle einer linearen Funktion ***");
            Console.WriteLine("   ************************************************************************");
            Console.WriteLine("\n   \tBitte geben Sie für eine Funktion der Form\n\n   \t\tf(x) = mx + b\n");
            Console.Write("   \t  - die Größe m ein: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("   \t  - die Größe b ein: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n   \t Bei welchem x-Wert soll die Wertetabelle beginnen? ");
            anfangx = Convert.ToInt32(Console.ReadLine());
            Console.Write("   \t Bei welchem x-Wert soll die Wertetabelle enden?    ");
            endex = Convert.ToInt32(Console.ReadLine());
            Console.Write("   \t Geben Sie jetzt noch eine Schrittweite für x ein:  ");
            schrittweite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n   \tDie Funktionsgleichung lautet:  y = " + m + "x + " + b);
            Console.WriteLine("\n\n   \t\t|\tx\t|\ty\t|");
            Console.WriteLine("   \t\t|---------------|---------------|");
            for (int i = anfangx; i <= endex; i=i+schrittweite)
            {
                y = m * i + b;
                Console.WriteLine("   \t\t|\t" + i + "\t|\t" + y + "\t|");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void Schaltjahr()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            int xx = 0;
            int yy = 0;
            Console.WriteLine("\n\tProgramm zur Ermittlung der Schaltjahre von 19XX bis 20YY");
            Console.WriteLine("\t---------------------------------------------------------");
            Console.Write("\tGeben Sie fuer XX eine zweistellige Zahl ein: ");
            xx = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tGeben Sie fuer YY eine zweistellige Zahl ein: ");
            yy = Convert.ToInt32(Console.ReadLine());
            xx += 1900;
            yy += 2000;
            Console.WriteLine();
            for (int i = xx; i <= yy; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("\t" + i + " Schaltjahr!");
                }
                else
                {
                    Console.WriteLine("\t" + i);
                }
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void Statistik()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            double zähler = 0;
            double eingabe = 0;
            double summe = 0;
            double mittelwert = 0;
            Console.WriteLine("\n\t\tS t a t i s t i k");
            Console.WriteLine("\t\t-----------------");
            Console.Write("\tWieviele Werte wollen Sie eingeben? ");
            zähler = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= zähler; i++)
            {
                Console.Write("\tBitte " + i + ". Zahl eingeben : ");
                eingabe = Convert.ToDouble(Console.ReadLine());
                summe += eingabe;
            }
            Console.WriteLine("\n\tSumme der Zahlen          =       " + summe);
            mittelwert = summe / zähler;
            Console.WriteLine("\tMittelwert der Zahlen     =       " + mittelwert);
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void Zufallszahlen()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            int eingabe = 0;
            int min = 0;
            int max = 0;
            Random zufall = new Random();
            Console.WriteLine("\t*** Ausgabe von Zufallszahlen ***");
            Console.Write("\n\tWieviele Zufallszahlen sollen ausgegeben werden? ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            int[] werte = new int[eingabe];
            Console.WriteLine("\tIn welchem Bereich sollen die Zahlen liegen?");
            Console.Write("\tVon: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tBis: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("\t");
            for (int i = 0; i < eingabe; i++)
            {          
                werte[i] = zufall.Next(min, max);
                Console.Write(werte[i] + "\t");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        public static void UmsatzstatistikMitArrays()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            double tagesumsatz = 0;
            double gesamtumsatz = 0;
            double durchschnittlicherumsatz = 0;
            double minumsatz = double.MaxValue;
            double maxumsatz = 0;
            double mintag = 0;
            double maxtag = 0;
            Console.WriteLine("\t\t\t***** Umsatzstatistik *****");
            Console.WriteLine("\nBitte geben Sie die Tagesumsaetze der letzten Woche der Reihe nach ein.\n\n");
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("\tTag " + i + ": ");
                tagesumsatz = Convert.ToDouble(Console.ReadLine());
                if (minumsatz >= tagesumsatz)
                {
                    minumsatz = tagesumsatz;
                    mintag = i;
                }
                if (maxumsatz <= tagesumsatz)
                {
                    maxumsatz = tagesumsatz;
                    maxtag = i;
                }
                gesamtumsatz += tagesumsatz;
            }
            Console.WriteLine("\n\nDer Gesamtumsatz der letzten Woche betraegt:     " + gesamtumsatz + " Euro");
            durchschnittlicherumsatz = gesamtumsatz / 7;
            Console.WriteLine("Der mittlere Umsatz der letzten Woche betraegt:   " + durchschnittlicherumsatz + " Euro");
            Console.WriteLine("\nDer hoechste Umsatz wurde mit " + maxumsatz + " Euro am " + maxtag + ".Tag der Woche erzielt.");
            Console.WriteLine("Der geringste Umsatz wurde mit " + minumsatz + " Euro am " + mintag + ".Tag der Woche erzielt.");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}

