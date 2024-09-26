//Game Dev Foundations
//Austin Rebelo
//Assignment 1

// Displays title and asks for a name
Console.WriteLine("The Ultimate Short Quest\n");
Console.WriteLine("Enter your name adventuer.");

// Gets user input for a name and displays it
string name = Console.ReadLine();
Console.WriteLine("Welcome " + name + "!\n");

// Ask user to select a class
Console.WriteLine("To begin, please select a class\n");
Console.WriteLine("1. Warrior, equiped with a sword and shield");
Console.WriteLine("2. Ranger, has a quiver containing normal and explosive arrows");
Console.WriteLine("3. Mage, wields fire and ice magic");
int playerClass = int.Parse(Console.ReadLine());

// If the user types "1", they play as a warrior
if (playerClass == 1)
{
    Console.WriteLine();
    Console.WriteLine("You are " + name + " the ranger. You are on a quest to defeat the almighty King of Frost! \n");
    Console.WriteLine("The King of Frost readies himself! Prepare to attack");
    Console.WriteLine("Actions\n");
    Console.WriteLine("1. Sword");
    Console.WriteLine("2. Shield");
}