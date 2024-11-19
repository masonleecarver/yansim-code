public class EternalGoal : Goal
{

    public EternalGoal() :base() {}

    public override string GetClass()
    {
        return "EternalGoal";
    }

    public override void Complete()
    {
        _completed = false;
    }

    public override string Display()
    {
        return $"[] {DisplayGoal()}";
    }
}