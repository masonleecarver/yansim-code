public class Armor : Item 
{
    int _defense;

    public Armor(string name, string description, int value, int defense)
        :base(name, description, value)
    {
        _defense = defense;
    }

    public int GetDefense()
    {
        return _defense;
    }

}