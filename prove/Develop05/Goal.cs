abstract public class Goal  
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed = false;

    public void SetGoal()
    {
        Console.Write("What is the name your goal?: ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of your goal?: ");
        _description = Console.ReadLine();
        Console.Write("How many points should this goal be worth?: ");
        _points = Int32.Parse(Console.ReadLine());
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string DisplayGoal()
    {
        return $"{_name} ({_description})";
    }

    public bool Completed()
    {
        return _completed;
    }

    public void LoadAGoal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public virtual void EndMessage(Goals goals)
    {
        Console.WriteLine($"Congrats! You earned {_points} points.");
        goals.AddPoints(_points);
        Complete();
    }

    public virtual void Complete()
    {
        _completed = true;
    }

    public abstract string Display();

    public abstract string GetClass();

}