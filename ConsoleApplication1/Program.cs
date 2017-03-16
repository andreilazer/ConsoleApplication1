using System;

namespace CentricExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Course oop = new Course();
            oop.ProfessorName = "Creangă Ion";
            oop.Title = "OOP";
            Object obj = new Object();

            Console.WriteLine(obj.ToString());
            Console.WriteLine(oop.ToString());
        }
    }
}
