public class Shop
{

    List<Item> _shopInventory;
    Player _player1;

    public Shop(List<Item> shop, Player player)
    {
        _shopInventory = shop;
        _player1 = player;
    }

    public void Shopping()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the shop. You currently have {_player1.GetMoney()} moneys.\n");
        Console.WriteLine("You can either:\n\t1. Buy Something\n\t2. Sell Someting\n\t3. Equip Weapon\n\t4. Equip Armor\n\t5. Return");
        Console.Write("What would you like to do? ");
        string input = Console.ReadLine();

        if(input == "1")
        {
            Buy();
        }
        else if(input == "2")
        {
            Sell();
        }

        else if (input == "3")
        {
            EWeapon();
        }
        else if (input == "4")
        {
            EArmor();
        }
        else if(input == "5")
        {
            return;
        }
        else
        {
            Console.WriteLine("Something went wrong here...");
        }
    }

    public void Buy()
    {
        Console.WriteLine("The items we have for sell are: ");
        for(int i = 0; i < _shopInventory.Count; i++)
        {
            Console.WriteLine($"\t{i+1}. {_shopInventory[i].GetName()} - {_shopInventory[i].GetValue()} Moneys");
        }
        Console.Write("Which would you like to buy? (type 13 to quit): ");
        int choice = Int32.Parse(Console.ReadLine());
        if(choice != 13)
        {
            Item item = _shopInventory[choice-1];
            if(item.GetValue() < _player1.GetMoney())
            {
                _player1.ChangeMoney(-item.GetValue());
                _player1.AddInventory(item);
                Console.WriteLine("Thanks for your purchase.");
            }
            else
            {
                Console.WriteLine("You don't have enough money for this....");
            }
        }

        else { return; }

        Shopping();
    }

    public void Sell()
    {
        Console.WriteLine("The items you have for sell are: ");
        for(int i = 0; i < _player1.GetInventory().Count; i++)
        {
            Console.WriteLine($"\t{i+1}. {_player1.GetInventory()[i].GetName()} - Sell for: {_player1.GetInventory()[i].GetValue()/2} Moneys");
        }
        Console.Write("Which would you like to sell? (type 13 to quit): ");
        int choice = Int32.Parse(Console.ReadLine());
        if(choice != 13)
        {
            Item item = _player1.GetInventory()[choice-1];     
            _player1.ChangeMoney(item.GetValue()/2);
            _player1.RemoveInventory(item);
            Console.WriteLine("Thanks for selling us your useless garbage.");
        }

        else { return; }

        Shopping();
    }

    public void EWeapon()
    {
        List<Weapon> weapons = _player1.GetInventory().OfType<Weapon>().ToList();

        if (weapons.Count == 0)
        {
            Console.WriteLine("You have no weapons.");
            Thread.Sleep(2000);
        }

        else 
        {
            for (int i = 0; i < weapons.Count(); i++)
            {
                Console.WriteLine($"\t{i+1}. {weapons[i].GetName()} - {weapons[i].GetDamage()} ATK");
            }
            Console.Write("Which do you want to equip? (type 13 to quit): ");
           int choice = Int32.Parse(Console.ReadLine());
            if(choice != 13)
            {
                Weapon item = weapons[choice-1];     
                _player1.AddInventory(_player1.GetWeapon());
                _player1.RemoveInventory(item);
                _player1.ChangeWeapon(item);
                Console.WriteLine($"{_player1.GetName()} is now sporting the {item.GetName()}");
                Thread.Sleep(2000);
            }

            else { return; } 
        }

        Shopping();
    }

    public void EArmor()
    {
        List<Armor> armors = _player1.GetInventory().OfType<Armor>().ToList();

        if (armors.Count == 0)
        {
            Console.WriteLine("You have no armor.");
            Thread.Sleep(2000);
        }

        else 
        {
            for (int i = 0; i < armors.Count(); i++)
            {
                Console.WriteLine($"\t{i+1}. {armors[i].GetName()} - {armors[i].GetDefense()} DEF");
            }
            Console.Write("Which do you want to equip? (type 13 to quit): ");
           int choice = Int32.Parse(Console.ReadLine());
            if(choice != 13)
            {
                Armor item = armors[choice-1];     
                _player1.AddInventory(_player1.GetArmor());
                _player1.RemoveInventory(item);
                _player1.ChangeArmor(item);
                Console.WriteLine($"{_player1.GetName()} dawned the {item.GetName()}");
                Thread.Sleep(2000);
            }

            else { return; } 
        }

        Shopping();
    }
}