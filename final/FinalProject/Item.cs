public abstract class Item 
{
    protected string _name;
    protected string _description;
    protected int _value;

    public Item(string name, string description, int value)
    {
        _name = name;
        _description = description;
        _value = value;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetValue()
    {
        return _value;
    }
}