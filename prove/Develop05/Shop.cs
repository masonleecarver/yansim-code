public class Shop 
{
    private List<Item> _shopInventory;
    private List<Item> _inventory = new();

    public Shop(List<Item> shopInventory)
    {
        _shopInventory = shopInventory;
    }

    public void Shopping(Event goals)
    {
        Console.WriteLine("You can either:\n\t1. Buy Something\n\t2. Veiw what you've bought\n\t3. Return");
        Console.Write("What would you like to do? ");
        string input = Console.ReadLine();

        if(input == "1")
        {
            Buy(goals);
        }
        else if(input == "2")
        {
            DisplayInventory();
        }
        else if(input == "3")
        {
            return;
        }
        else
        {
            Console.WriteLine("Something went wrong here...");
        }
    }

    public void Buy(Event goals)
    {
        Console.WriteLine("The items we have for sell are: ");
        for(int i = 0; i < _shopInventory.Count; i++)
        {
            Console.WriteLine($"\t{i+1}. {_shopInventory[i].DisplayInfo()}");
        }
        Console.Write("Which would you like to buy? (type 13 to quit): ");
        int choice = Int32.Parse(Console.ReadLine());
        if(choice != 13)
        {
            Item item = _shopInventory[choice-1];
            if(item.GetCost() < goals.GetTotalPoints())
            {
                item.Sell(goals);
                _inventory.Add(item);
                Console.WriteLine("You bought it.");
            }
            else
            {
                Console.WriteLine("You don't have enough points for this....");
            }
        }

    }

    public void DisplayInventory()
    {
        Console.WriteLine("You have bought...");
        for(int i = 0; i < _inventory.Count; i++)
        {
            Console.WriteLine($"\t{i+1}. {_inventory[i].GetName()}");
        }
    }
}