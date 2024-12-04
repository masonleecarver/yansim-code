using System.Data;

public class Weapon : Item 
{
    int _damage;

    public Weapon(string name, string description, int value, int damage)
        :base(name, description, value)
    {
        _damage = damage;
    }

    public int GetDamage()
    {
        return _damage;
    }
}