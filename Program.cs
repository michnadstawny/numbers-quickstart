using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void radius()
        {
            double r = 2.50;

            double result = Math.PI * Math.Pow(r, 2);

            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            radius();
        }
    }
}