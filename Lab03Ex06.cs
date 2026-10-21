Console.WriteLine("Hello Adventurer! Welcome to Liman RPG!");
Console.WriteLine("Enter your name: ");
string characterName = Console.ReadLine()!;

Console.WriteLine("Enter your maximum health: ");
int maxHP = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your current health (must be less than max health): ");
int currentHP = int.Parse(Console.ReadLine());

if (currentHP > maxHP)
{
    Console.WriteLine("Your current health is bigger than your max health! Don't cheat!");
    Environment.Exit(0);
}

Console.WriteLine("Enter your base attack damage: ");
int DMG = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your current amount of gold: ");
int goldAmount = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have a map? Enter (Y/N): ");
string mapAnswer = (Console.ReadLine());

string mapPosession = mapAnswer == "Y" ? "True" : "False";

bool isRich = goldAmount >= 100;

bool isAlive = currentHP > 0;

bool needsHealing = currentHP < 50;

bool isStrong = DMG > 100;

bool canDepart = isAlive == true && needsHealing == false && (mapPosession == "True" || isStrong == true);

Console.WriteLine("What do you aim to do on your adventure? Enter the number of your answer:\n1 - fight monsters\n2 - help people\n3 - explore the world");
int purposeAnswer = int.Parse(Console.ReadLine());

string purpose = " ";

switch (purposeAnswer)
{
    case 1:
        purpose = "The Monster Slayer";
        break;
    case 2:
        purpose = "The Servant of The People";
        break;
    case 3:
        purpose = "The Discoverer of Lands";
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("INVALID INPUT. RESTART OPERATION");
        Console.ResetColor();
        Environment.Exit(0);
        break;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+====================================== +");
Console.WriteLine(" | CHARACTER PROFILE |");
Console.WriteLine("+====================================== +");
Console.WriteLine($"| NAME AND TITLE: {characterName} {purpose} |");
Console.WriteLine($"| CURRENT HEALTH/MAX HEALTH: {currentHP} / {maxHP} |");
Console.WriteLine($"| ATTACK DAMAGE: {DMG} |");
Console.WriteLine($"| GOLD: {goldAmount} |");
Console.WriteLine($"| HAS MAP: {mapPosession} |");
Console.WriteLine("+ --------------------------------------+");
Console.WriteLine($"| REALLY POWERFUL: {isStrong} |");
Console.WriteLine($"| ALIVE: {isAlive} |");
Console.WriteLine($"| NEEDS HEALING: {needsHealing} |");
Console.WriteLine($"| HAS MAP : {mapPosession} |");
Console.WriteLine($"| IS RICH: {isRich} |");
Console.WriteLine($"| READY FOR ADVENTURE: {canDepart} |");
Console.WriteLine("+====================================== +");
Console.ResetColor();