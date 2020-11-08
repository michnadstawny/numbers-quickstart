using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = 100;
            double e = 19;
            double f = 23;
            double g = 8;
            double h = 144;
            double wynik1 = d / a + (b * c) - (e - f) * (h - g);
            double wynik2 = g * (d * f / c) - a * (b + e) - h;
            Console.WriteLine(wynik1);
            Console.WriteLine(wynik2);
        }

        static void Main(string[] args)
        {
            WorkWithDoubles();
        }
    }
}