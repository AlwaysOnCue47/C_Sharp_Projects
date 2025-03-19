using System;

namespace EFCodeFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Final Assignment Submission App");
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();

        }
    }
}
