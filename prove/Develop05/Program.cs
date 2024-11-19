using System;

class Program
{
    static void Main(string[] args)
    {
        Item unicorn = new Item("Sparkly Unicorn", "It will do your homework for you. Unicorns are very smart.", 400);
        Item ninjana = new Item("Ninjana", "A ninja banana. Need I say more?", 150);
        Item finger = new Item("A Sixth Finger", "So writing journals becomes that much easier.", 600);
        Item money = new Item("A Wad of Cash", "It's just a pile of cash.", 50);
        string input = "0";
        Goals eventHandler = new Goals();
        Shop shop = new Shop([unicorn, ninjana, finger, money]);

        do
        {
            eventHandler.DisplayPoints();

            Console.WriteLine("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Clear Screen\n\t7. Visit Shop\n\t8. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if(input == "1")
            {
                eventHandler.MakeGoal();
            }

            else if(input == "2")
            {
                eventHandler.DisplayGoals();
            }

            else if(input == "3")
            {
                eventHandler.Save();
            }

            else if(input == "4")
            {
                eventHandler.Load();
            }

            else if(input == "5")
            {
                eventHandler.CompleteGoals(eventHandler);
            }

            else if(input == "6")
            {
                Console.Clear();
            }
            else if(input == "7")
            {
                shop.Shopping(eventHandler);
            }
            else if(input == "8")
            {
                break;
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }
        }
        while(input != "8");
    }
}