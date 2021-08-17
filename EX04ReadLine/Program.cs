using System;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            Console.WriteLine("Skriv dit fornavn.");
            string firstName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Skriv dit efternavn.");
            string lastName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Velkommen {firstName} {lastName}");
            Console.WriteLine("");
            Console.WriteLine("Skriv din alder.");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Din alder er {age}.");
        }
    }
}