using System;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dit fornavn.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Skriv dit efternavn.");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Velkommen {firstName} {lastName}");
            Console.WriteLine("Skriv din alder.");
            int age = int.Parse(Console.ReadLine());
        }
    }
}