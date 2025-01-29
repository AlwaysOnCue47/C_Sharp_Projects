using System;

namespace CallingMethodsAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert pounds to kilogram.");
            Console.WriteLine("Enter a value in pounds:");
            decimal lbs = Convert.ToDecimal(Console.ReadLine());
            decimal inKg = Operation1.Kilogram(lbs);
            Console.WriteLine(inKg.ToString());
            decimal inOz = Operation1.Ounce(lbs);
            Console.WriteLine(inOz.ToString());
            decimal inGram = Operation1.Grams(lbs);
            Console.WriteLine(inGram.ToString());
        }
    }
}
