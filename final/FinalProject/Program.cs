using System;

class Program
{
    static void Main(string[] args)
    {
        Weapon unicornHorn = new Weapon("Unicorn Horn", "How did you get this? Not ethically, that's for sure.", 10, 4);
        Weapon sword = new Weapon("Sword", "It's a sword.", 6, 5);
        Weapon hands = new Weapon("Left Hook!!", "Your fists.", 0, 3);

        Armor tutu = new Armor("Tutu", "Aww... so cute.", 5, 2);
        Armor chainmail = new Armor("Chainmail", "It's overpowered.", 8, 6);
        Armor nothing = new Armor("Streaker", "That's illegal.", 0, 2);

        Healer chocolate = new Healer("Chocolate Bar", "It's scrumptious!", 4, 20);
        Healer tums = new Healer("Tums", "For indigestion.", 6, 40);
        Healer sandwich = new Healer("Tuna Fish Sandwich", "It's disgusting... but's it's probably good for you.", 14, 50);

        FinalChoice runAway = new FinalChoice("You hit a tree. Ouch.", "Cry", "Die", "You are very sad.", "You are born again... as a worm.");
        FinalChoice wings = new FinalChoice("Take a leap of faith!!", "Go into the sun.", "Stalk your boyfriend.", "Icarus is FLLLYING to CLOSE. TO THE. SUN.", "i can smell you through the walls.");
        Choice right = new Choice("You run into a cliff.", "Run away", "Grow wings", runAway, wings);
        FinalChoice goInside = new FinalChoice("It smells like BURNING HAIR IN HERE.", "Leave and never come back.", "Kick the homeless man.", "Good choice.", "He gave you 2 matches and a temporary tatoo.");
        FinalChoice burn = new FinalChoice("It crackles nicely. But there's a squirrel family that needs rescuing!!", "I HAVE NO SOUL.", "SAVE THEM!!!!", "Me neither. I'll see you in the afterlife.", "The reward you with eternal life...");
        Choice left = new Choice("It's a creepy haunted house...", "Go inside.", "BURN IT.", goInside, burn);
        Choice road = new Choice("You arrive at a road.", "Go left.", "Go right.", left, right);

        Player player = new Player("Elephant", 50, 8, 9, unicornHorn, tutu);

        Enemy rizzler = new Enemy("The Rizzler", 30, 2, 4, sword, tutu, 150, 40);
        Enemy boulder = new Enemy("Boulder", 30, 5, 6, hands, nothing, 20, 30);

        Battle battle = new Battle([rizzler, boulder], player);

        Shop shop = new Shop([unicornHorn, sword, tutu, chainmail, chocolate, tums, sandwich], player);

        player.AddInventory(chocolate);
        player.AddInventory(sandwich);
        player.AddInventory(sandwich);

        Console.WriteLine("Welcome to my totally awesome game B)");
        Thread.Sleep(2000);
        Console.WriteLine("You even have the opporunity to pick out the name of your character!!");        
        player.SetName();
        Thread.Sleep(1000);
        Console.WriteLine($"{player.GetName()}? Great name. Let's go on a quest.");
        Thread.Sleep(2000);
        Console.Clear();
        road.Choose();

        Thread.Sleep(3000);
        // Console.Clear();
        Console.WriteLine("Let's go shopping.");
        shop.Shopping();
        Console.WriteLine("Battle incoming!!!");
        Thread.Sleep(2000);

        battle.Turn();

        Console.WriteLine("Yup... it totally works. Awesome.");
    }
}