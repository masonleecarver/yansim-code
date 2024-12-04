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

        Player player = new Player("Elephant", 50, 8, 9, unicornHorn, chainmail);

        Enemy rizzler = new Enemy("The Rizzler", 30, 2, 4, sword, tutu, 150, 40);
        Enemy boulder = new Enemy("Boulder", 30, 5, 6, hands, nothing, 20, 30);

        Battle battle = new Battle([rizzler, boulder], player);

        player.AddInventory([chocolate, tums, sandwich]);

        Console.WriteLine("Welcome to my totally awesome game B)");
        Thread.Sleep(2000);
        Console.WriteLine("You even have the opporunity to pick out the name of your character!!");        
        player.SetName();
        Thread.Sleep(1000);
        Console.WriteLine($"{player.GetName()}? Great name. But they don't think so!!!");
        Thread.Sleep(2000);
        Console.WriteLine("Battle incoming!!!");
        Thread.Sleep(2000);

        battle.Turn();

        Console.WriteLine("Yup... it totally works. Awesome.");
    }
}