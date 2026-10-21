using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wiek: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Niepoprawny wiek.");
        }
        else if (age <= 12)
        {
            Console.WriteLine("Dziecko");
        }
        else if (age <= 17)
        {
            Console.WriteLine("Nastolatek");
        }
        else if (age <= 64)
        {
            Console.WriteLine("Osoba dorosła");
        }
        else
        {
            Console.WriteLine("Senior");
        }
    }
}
