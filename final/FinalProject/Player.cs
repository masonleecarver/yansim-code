public class Player : Character
{
    int _level = 1;
    int _exp = 0;
    int _money = 20;
    List<Item> _inventory = new();

    public Player(string name, int maxHealth, int speed, int attack, Weapon weapon, Armor armor) :base(name, maxHealth, speed, attack, weapon, armor) {}
    public List<Item> GetInventory()
    {
        return _inventory;
    }

    public void ManualHealth(int hp)
    {
        _health = hp;
    }
    public void SetName()
    {
        Console.Write("What is the name of your hero? ");
        _name = Console.ReadLine();
    }

    public int GetMoney()
    {
        return _money;
    }

    public Weapon GetWeapon()
    {
        return _weapon;
    }

    public Armor GetArmor()
    {
        return _armor;
    }

    public void ChangeMoney(int money)
    {
        _money += money;
    }

    public void ChangeWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }

    public void ChangeArmor(Armor armor)
    {
        _armor = armor;
    }

    public void ChangeExp(int exp)
    {
        _exp += exp;
    }

    public void GetHealed(int healed)
    {
        _health += healed;
    }

    public void AddInventory(Item item)
    {
        _inventory.Add(item);
    }

    public void RemoveInventory(Item item)
    {
        _inventory.Remove(item);
    }

    public void LevelUp()
    {
        if(_exp >= 100)
        {
            _level += 1;
            _maxHealth += 30;
            _health = _maxHealth;
            _speed += 2;
            _attack += 2;

            Console.WriteLine($"Congrats! {_name} leveled up to level {_level}!");

            _exp = 0;
        }
    }

    public override void Defeated(Character enemy)
    {
        // game over. battle resets. stuff like that.
    }

}
