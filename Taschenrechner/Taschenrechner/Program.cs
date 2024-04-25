using System;

namespace Mathe
{
    class Taschenrechner
    {
        // Methoden für verschiedene mathematische Operationen
        public double Addition(double x, double y) { return x + y; }
        public double Subtraktion(double x, double y) { return x - y; }
        public double Multiplikation(double x, double y) { return x * y; }
        public double Division(double x, double y) { return x / y; }

        public double Sinus(double x) { return Math.Sin(x); }
        public double Cosinus(double x) { return Math.Cos(x); }
        public double Tangens(double x) { return Math.Tan(x); }

        public double Potenzieren(double x, double y) { return Math.Pow(x, y); }
        public double WurzelZiehen(double x) { return Math.Sqrt(x); }
        public double Logarithmus(double x) { return Math.Log(x); }

        // Methode zur Berechnung der Fakultät einer Zahl
        public double Fakultaet(double x)
        {
            double result = 1;
            for (double i = x; i > 0; i--) { result *= i; } // Berechnung/Formel der Fakultät
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Taschenrechner-Klasse wird erstellt
            Taschenrechner t = new Taschenrechner();

            while (true)
            {
                Console.Clear(); // Löscht die Konsole, damit sie wieder sauber ist
                // Benutzereingabe für die Zahlen
                Console.Write("Geben Sie die erste Zahl ein: ");
                double zahl1 = Convert.ToDouble(Console.ReadLine());

                char op;

                // Benutzereingabe für die Auswahl der Operation
                Console.WriteLine("Wählen sie eine Operation aus: (+ für Addition) (- für Subtraktion) (* für Multiplikation) (/ für Division) \n (f für Fakultät) (s für Sinus) (c für Cosinus) (t für Tangens) (p für Potenzieren) (w für Wurzelziehen) \n (l für Logarithmus)");

                op = Convert.ToChar(Console.ReadLine());


                // Abchecken welche Operation eingegeben/gewählt wurde
                // Das die zweite Zahl nicht gebraucht wird, wenn man nur eine Zahl braucht (zB: Wurzelziehen oder Cosinus...), deswegen je nach Operation einzelnd ersetellt
                switch (op)
                {
                    case '+':
                        Console.Write("Geben Sie die zweite Zahl ein: ");
                        double zahl_add = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(t.Addition(zahl1, zahl_add));
                        break;
                    case '-':
                        Console.Write("Geben Sie die zweite Zahl ein: ");
                        double zahl_sub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(t.Subtraktion(zahl1, zahl_sub));
                        break;
                    case '*':
                        Console.Write("Geben Sie die zweite Zahl ein: ");
                        double zahl_mult = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(t.Multiplikation(zahl1, zahl_mult));
                        break;
                    case '/':
                        Console.Write("Geben Sie die zweite Zahl ein: ");
                        double zahl_div = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(t.Division(zahl1, zahl_div));
                        break;
                    case 'f':
                        Console.WriteLine(t.Fakultaet(zahl1));
                        break;
                    case 's':
                        Console.WriteLine(t.Sinus(zahl1));
                        break;
                    case 'c':
                        Console.WriteLine(t.Cosinus(zahl1));
                        break;
                    case 't':
                        Console.WriteLine(t.Tangens(zahl1));
                        break;
                    case 'p':
                        double potenz;
                        Console.WriteLine("Gib eine Hochzahl ein: ");
                        potenz = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(t.Potenzieren(zahl1, potenz));
                        break;
                    case 'w':
                        Console.WriteLine(t.WurzelZiehen(zahl1));
                        break;
                    case 'l':
                        Console.WriteLine(t.Logarithmus(zahl1));
                        break;
                    default:
                        Console.WriteLine("Schreib eine gültige Operation ein!");
                        break;
                }


                // wartet bis er eine taste liest
                Console.ReadKey();
            }
            
        }
    }
}
