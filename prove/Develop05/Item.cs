public class Item
{
    private string _name;
    private string _description;
    private int _cost;

    public Item(string name, string description, int cost)
    {
        _name = name;
        _description = description;
        _cost = cost;
    }

    public string DisplayInfo()
    {
        return $"{_name} - {_description} - {_cost} points.";
    }

    public string GetName()
    {
        return _name;
    }

    public int GetCost()
    {
        return _cost;
    }

    public void Sell(Goals goals)
    {
        goals.RemovePoints(_cost);
    }

}