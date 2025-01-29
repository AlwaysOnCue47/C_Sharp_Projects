using System;

namespace CallingMethodsAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert pounds to kilogram.");
            Console.WriteLine("Enter a value in pounds:");
            double lbs = Convert.ToDouble(Console.ReadLine());
            double inKg = Operation1.Kilogram(lbs);
            Console.WriteLine(inKg.ToString());
            double inOz = Operation1.Ounce(lbs);
            Console.WriteLine(inOz.ToString());
            double inGram = Operation1.Grams(lbs);
            Console.WriteLine(inGram.ToString());
        }
    }
}
