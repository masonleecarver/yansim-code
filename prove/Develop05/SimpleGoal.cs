public class SimpleGoal:Goal
{

    public SimpleGoal() :base() {}

    public override string GetClass()
    {
        return "SimpleGoal";
    }

    public override string Display()
    {
        string check = "[]";
        if(_completed)
        {
            check = "[X]";
        }

        return $"{check} {DisplayGoal()}";
    }
}
