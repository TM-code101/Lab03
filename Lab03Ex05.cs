Console.WriteLine("===BATTLE BEGINS===");
Console.WriteLine("Enter your current amount of health: ");
int HP = int.Parse(Console.ReadLine());

bool isAlive = HP > 0;
bool needsHealing = HP < 20;


Console.WriteLine("Enter your base damage: ");
int DMG = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have potions? Enter (Y/N)");
string haspotions = Console.ReadLine();

int potionAmount = 0;

if (haspotions == "Y")
{
    Console.WriteLine("Enter your current amount of potions: ");
    potionAmount = int.Parse(Console.ReadLine());
}
else if (haspotions == "N")
{
    potionAmount = 0;
}
else
{
    Console.WriteLine("Invalid input. Restart the program.");
    Environment.Exit(0);
}

Console.WriteLine("Enter a number to choose your action:\n1 - attack\n 2 - heal\n 3 - escape ");
int actionChoice = int.Parse(Console.ReadLine());

if (isAlive == false)
{
    Console.WriteLine("You're dead!");
    Environment.Exit(0);
}


switch (actionChoice)
{
    case 1:
        Console.WriteLine($"You did {DMG} damage to the enemy!");
        break;

    case 2:

        if (potionAmount > 0)
        {
            Console.WriteLine($"You used 1 potion to heal yourself! You have {potionAmount - 1} potions left!");
            HP += 10;
        }
        else {
        Console.WriteLine("You didn't have any potions on you so you got killed while looking for one in your empty pockets...");
        }
        break;
    case 3:
        Console.WriteLine("You escaped. Coward!");
            break;
    default:
        Console.WriteLine("Invalid input. Restart the program. ");
        break;
}
if (needsHealing == true)
{
    Console.WriteLine($"You need healing! You only have {HP} health left!");
}
