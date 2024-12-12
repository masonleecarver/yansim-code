using System;

class Program
{
    static void Main(string[] args)
    {
        #region items

        Weapon unicornHorn = new Weapon("Unicorn Horn", "How did you get this? Not ethically, that's for sure.", 10, 4);
        Weapon sword = new Weapon("Sword", "It's a sword.", 6, 5);
        Weapon hands = new Weapon("Left Hook!!", "Your fists.", 0, 3);
        Weapon knife = new Weapon("Blade of Death", "it brings pain.", 20, 10);
        Weapon genericWeapon = new Weapon("Weapon?", "It's a weapon... what is this?", 12, 8);

        Armor tutu = new Armor("Tutu", "Aww... so cute.", 5, 2);
        Armor chainmail = new Armor("Chainmail", "It's overpowered.", 8, 6);
        Armor nothing = new Armor("Streaker", "That's illegal.", 0, 2);
        Armor cuteypie = new Armor("Get Cuter", "They won't hit you if you're cute.", 20, 10);
        Armor genericArmor = new Armor("Armor?", "It's armor... huh?", 12, 8);

        Healer chocolate = new Healer("Chocolate Bar", "It's scrumptious!", 4, 20);
        Healer tums = new Healer("Tums", "For indigestion.", 6, 40);
        Healer sandwich = new Healer("Tuna Fish Sandwich", "It's disgusting... but's it's probably good for you.", 14, 50);
        Healer nail = new Healer("Nail biting!", "i'm so nervous guys", 3, 15);
        Healer paperBag = new Healer("Paper Bag", "In... out...", 16, 40);

        #endregion

        #region quest 1

        FinalChoice runAway = new FinalChoice("You hit a tree. Ouch.", "Cry", "Die", "You are very sad.", "You are born again... as a worm.");
        FinalChoice wings = new FinalChoice("Take a leap of faith!!", "Go into the sun.", "Stalk your boyfriend.", "Icarus is FLLLYING to CLOSE. TO THE. SUN.", "i can smell you through the walls.");
        Choice right = new Choice("You run into a cliff.", "Run away", "Grow wings", runAway, wings);
        FinalChoice goInside = new FinalChoice("It smells like BURNING HAIR IN HERE.", "Leave and never come back.", "Kick the homeless man.", "Good choice.", "He gave you 2 matches and a temporary tatoo.");
        FinalChoice burn = new FinalChoice("It crackles nicely. But there's a squirrel family that needs rescuing!!", "I HAVE NO SOUL.", "SAVE THEM!!!!", "Me neither. I'll see you in the afterlife.", "The reward you with eternal life...");
        Choice left = new Choice("It's a creepy haunted house...", "Go inside.", "BURN IT.", goInside, burn);
        Choice road = new Choice("You arrive at a road.", "Go left.", "Go right.", left, right);

        #endregion

        #region quest 2

        FinalChoice movies = new FinalChoice("The movies. It makes you feel... like you're in a 90s music video.", "GO WILD!! GO FERAL!!!", "i'm hungry.", "YEAH!! YEAHH!!! THIS IS AWESOME!! wait is that a cop", "Me too. Let's go shopping.");
        FinalChoice park = new FinalChoice("The park. Mmm. So nice.", "Beat up tiny children", "Lay on the ground and stare at the clouds", "WHAT THE HECK, MAN?!! WHY WOULD YOU DO THAT!!? I'M CALLING THE POLICE!!!", "Does that cloud look like a security guard to you?");
        Choice wake = new Choice("After waking up, you step outside in your lovely new neighborhood.", "Go to the park", "Go to the movies", park, movies);
        FinalChoice remain = new FinalChoice("Really? You've been sleeping for like, 24 hours.", "I just drove 12 hours to move here.", "I'm sad.", "I suppose you like the thrill of punching monsters and stealing their money...", "I can realte. You may sleep. But wait... is that... OH NO!!!");
        FinalChoice punch = new FinalChoice("You're punching the air because you can't sleep. I don't think this is helpful.", "Finally get out of bed", "Shut up I'm sleeping", "You're too late. It's already 6pm.", "And so you remained asleep for another 100 years until a handsome prince came along...");
        Choice sleep = new Choice("Just few more minutes... but...", "Punch the air", "Remain asleep", punch, remain);
        Choice bed = new Choice("You've awoken from that awful dream about fighting a Boulder and a Tumblr Sexyman.", "Stay in bed", "Wake up", sleep, wake);

        #endregion

        Player player = new Player("Elephant", 50, 8, 9, unicornHorn, tutu);

        Enemy rizzler = new Enemy("The Rizzler", 30, 2, 8, sword, tutu, 150, 40);
        Enemy boulder = new Enemy("Boulder", 30, 5, 7, hands, nothing, 150, 30);
        Enemy superCop = new Enemy("Super Cop Wellfare Check", 65, 4, 12, genericWeapon, genericArmor, 40, 60);
        Enemy kid = new Enemy("Angry Kid", 35, 16, 9, knife, cuteypie, 50, 12);

        Battle battle = new Battle([rizzler, boulder], player);
        Battle battle2 = new Battle([superCop, kid], player);

        Shop shop = new Shop([unicornHorn, sword, tutu, chainmail, chocolate, tums, sandwich], player);
        Shop shop2 = new Shop([knife, genericWeapon, cuteypie, genericArmor, nail, paperBag], player);

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
        Console.Clear();
        Console.WriteLine("Let's go shopping.");
        Thread.Sleep(2000);
        shop.Shopping();
        Console.WriteLine("Battle incoming!!!");
        battle.Turn();
        Thread.Sleep(2000);
        player.ManualHealth(player.GetMaxHealth());
        bed.Choose();
        Thread.Sleep(2000);
        Console.WriteLine("You know what? Let's go shopping again before we get our butts kicked.");
        Thread.Sleep(2000);
        shop2.Shopping();
        Console.WriteLine("Here it comes...");
        battle2.Turn();

        Console.WriteLine("Yup... it totally works. Awesome.");
    }
}