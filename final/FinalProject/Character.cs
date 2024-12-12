public abstract class Character
{
    protected string _name;
    protected int _maxHealth;

    protected int _health;
    protected int _speed;
    protected int _attack;
    protected Weapon _weapon;
    protected Armor _armor;
    protected bool _alive = true;

    public Character(string name, int maxHealth, int speed, int attack, Weapon weapon, Armor armor)
    {
        _name = name;
        _maxHealth = maxHealth;
        _health = maxHealth;
        _speed = speed;
        _attack = attack;
        _weapon = weapon;
        _armor = armor;
    }
    public bool GetAlive()
    {
        return _alive;
    }

    public int GetHealth()
    {
        return _health;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }

    public int Defense()
    {
        return _armor.GetDefense();
    }

    public int GetAttack()
    {
        return _attack + _weapon.GetDamage();
    }
    public int GetSpeed()
    {
        return _speed;
    }
    public string GetName()
    {
        return _name;
    }

    public void ManualHealth(int hp)
    {
        _health = hp;
    }

    public void SetAlive(bool alive)
    {
        _alive = alive;
    }

    public void TakeDamage(int damage, Character character)
    {
        Console.WriteLine($"{character.GetName()} is attacking {_name}!");
        Thread.Sleep(2000);

        if (damage < 0)
        {
            damage = 1;
        }
        _health -= damage;
        if (_health <= 0)
        {
            _health = 0;
            _alive = false;
            Defeated(character);
        }

        Console.WriteLine($"{_name} now has {_health} HP left!\n");
        Thread.Sleep(2000);
    }

    public void Attack(Character enemy)
    {
        enemy.TakeDamage(_attack + _weapon.GetDamage() - enemy.Defense(), this);
    }

    public abstract void Defeated(Character player);





}