using System;

namespace ParsingEnumAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter a day of the week:");
                    string userInput = Console.ReadLine();
                    DayOfWeek dayValue = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput);
                    Console.WriteLine($"Have a good: {dayValue}!");
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Type the name exactly correct - first letter is capital.");
                }
            }
        }

        enum DaysOfTheWeek {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }
    }
}
