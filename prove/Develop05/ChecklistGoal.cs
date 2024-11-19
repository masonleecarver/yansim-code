public class ChecklistGoal : Goal
{
    private int _finalPoints;
    private int _rounds;
    private int _done = 0;

    public ChecklistGoal() :base() {}

    public override string GetClass()
    {
        return "ChecklistGoal";
    }

    public int GetRounds()
    {
        return _rounds;
    }

    public int GetDone()
    {
        return _done;
    }

    public int GetFinalPoints()
    {
        return _finalPoints;
    }

    public void SetRoundsAndFinalPoints()
    {
        Console.Write("How many times until this goal is complete?: ");
        _rounds = Int32.Parse(Console.ReadLine());
        Console.Write("How many points would you like the final points to be?: ");
        _finalPoints = Int32.Parse(Console.ReadLine());

    }

    public void LoadInfo(int finalpoints, int rounds, int done)
    {
        _finalPoints = finalpoints;
        _rounds = rounds;
        _done = done;
    }

    public override void EndMessage(Goals goals)
    {
        _done += 1;

        if(_done >= _rounds)
        {
            _points += _finalPoints;
            Complete();
        }

        Console.WriteLine($"Congrats! You earned {_points} points.");
        goals.AddPoints(_points);
    }

    public override string Display()
    {
        string check = "[]";
        if(_done >= _rounds)
        {
            check = "[X]";
        }

        return $"{check} {DisplayGoal()} - Completed {_done}/{_rounds}";
        
    }

}