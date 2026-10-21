using System;

class Program
{
    static void Main()
    {
        Console.Write("Health points: ");
        int healthPoints = int.Parse(Console.ReadLine());

        Console.Write("Has key: (true/false): ");
        bool hasKey = bool.Parse(Console.ReadLine());

        Console.Write("Knows password: (true/false): ");
        bool knowsPassword = bool.Parse(Console.ReadLine());

        bool isAlive = healthPoints > 0;
        bool hasAccess = hasKey || knowsPassword;
        bool canEnter = isAlive && hasAccess;

        if (!isAlive)
        {
            Console.WriteLine("Character can't enter the dungeon - he's dead.");
        }
        else if (canEnter)
        {
            Console.WriteLine("Character can enter the dungeon.");
        }
        else
        {
            Console.WriteLine("Character can't enter the dungeon - no way to enter.");
        }
    }
}