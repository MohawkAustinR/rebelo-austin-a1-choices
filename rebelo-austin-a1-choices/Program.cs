//Game Dev Foundations
//Austin Rebelo
//Assignment 1

// Displays title and asks for a name
Console.WriteLine("The Ultimate Short Quest\n");
Console.WriteLine("Enter your name, adventurer.");

// Gets user input for a name and displays it
string name = Console.ReadLine();
Console.WriteLine($"Welcome,{name}!\n");

// Ask user to select a class
Console.WriteLine("To begin, please select a class.\n");
Console.WriteLine("1. Warrior, equipped with a sword and shield");
Console.WriteLine("2. Ranger, has a quiver containing normal and explosive arrows");
Console.WriteLine("3. Mage, wields fire and ice magic");
int playerClass = int.Parse(Console.ReadLine());

// If the user types "1", they play as a warrior
if (playerClass == 1)
{
    Console.WriteLine();
    Console.WriteLine($"You are {name}, the warrior. You are on a quest to defeat the almighty King of Frost!\nYou leave your village and journey the path to the kings fortress... and you've arrived!\n(With such a short walk you'd expect someone to have challenged the king already.)\n");
    Console.WriteLine("The King of Frost readies himself! Prepare to attack.");
    Console.WriteLine("Actions\n");
    Console.WriteLine("1. Sword");
    Console.WriteLine("2. Shield");
    int warriorAction = int.Parse(Console.ReadLine());

    // If user types "1", they use a sword and win
    if (warriorAction == 1)
    {
        Console.WriteLine();
        Console.WriteLine("You charge at the king and plunge your sword through his chest!\nThe King of Frost falls, defeated in one stab... Well that was easy.\n");
        Console.WriteLine("YOU WIN!");
    }

    // If user types "2", they use a shield and lose
    else if (warriorAction == 2)
    {
        Console.WriteLine();
        Console.WriteLine("You raise your shield, preparing for the kings attack.\nThe King of Frost summons ice spikes from beneath you, rendering your shield useless.\nObviously it wouldn't be that simple to beat the king.\n");
        Console.WriteLine("YOU LOSE!");
    }


}
// If the user types "2", they play as a ranger
else if (playerClass == 2)
{
    Console.WriteLine();
    Console.WriteLine($"You are {name}, the ranger. You are on a quest to defeat the almighty King of Frost!\nYou leave your village and journey the path to the kings fortress... and you've arrived!\n(With such a short walk you'd expect someone to have challenged the king already.)\n");
    Console.WriteLine("The King of Frost readies himself! Prepare to attack.");
    Console.WriteLine("Actions\n");
    Console.WriteLine("1. Normal Arrow");
    Console.WriteLine("2. Explosive Arrow");
    int rangerAction = int.Parse(Console.ReadLine());

    // If user types "1", they use a normal arrow and lose
    if (rangerAction == 1)
    {
        Console.WriteLine();
        Console.WriteLine("You fire an arrow straight for the king.\nThe king grabs the arrow inches before his face, freezing it, and sends it flying back at you!\nThe arrow pierces you through the chest.\n");
        Console.WriteLine("YOU LOSE!");
    }

    // If user types "2", they use an explosive arrow and win
    else if (rangerAction == 2)
    {
        Console.WriteLine();
        Console.WriteLine("You fire an explosive arrow towards the king.\nThe king grabs the arrow inches before his face, though not realising a comically large bomb on the end.\nThe bomb explodes in his face, killing him instantly.\n");
        Console.WriteLine("YOU WIN!");
    }

}

// If the user types "3", they play as a 3
else if (playerClass == 3)
{
    Console.WriteLine();
    Console.WriteLine($"You are {name}, the mage. You are on a quest to defeat the almighty King of Frost!\nYou leave your village and journey the path to the kings fortress... and you've arrived!\n(With such a short walk you'd expect someone to have challenged the king already.)\n");
    Console.WriteLine("The King of Frost readies himself! Prepare to attack.");
    Console.WriteLine("Actions\n");
    Console.WriteLine("1. Frostbolt");
    Console.WriteLine("2. Fireball");
    int mageAction = int.Parse(Console.ReadLine());

    // If user types "1", they use a frostbolt and lose
    if (mageAction == 1)
    {
        Console.WriteLine();
        Console.WriteLine("You cast a frostbolt at the king... The King of Frost...\nNothing happens and in response, the king creates a huge wall of ice and drops it on you.\n(I hope this wasn't your serious choice.)\n");
        Console.WriteLine("YOU LOSE!");
    }

    // If user types "2", they use a fireball and win
    else if (mageAction == 2)
    {
        Console.WriteLine();
        Console.WriteLine("You cast a fireball at the king.\nThe fireball collides with the king, engulfing him in flames.\nBefore you know it, the king is nothing more than ash.\n");
        Console.WriteLine("YOU WIN!");
    }

}