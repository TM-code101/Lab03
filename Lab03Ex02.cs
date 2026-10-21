using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj kierunek (północ, południe, wschód, zachód): ");
        string direction = Console.ReadLine();

        switch (direction)
        {
            case "północ":
                Console.WriteLine("Wyruszasz w stronę gór.");
                break;
            case "południe":
                Console.WriteLine("Wyruszasz w stronę pustyni.");
                break;
            case "wschód":
                Console.WriteLine("Wyruszasz w stronę lasu.");
                break;
            case "zachód":
                Console.WriteLine("Wyruszasz w stronę morza.");
                break;
            default:
                Console.WriteLine("Nieznany kierunek.");
                break;
        }
    }
}