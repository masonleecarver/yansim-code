public class FinalChoice : Choice
{

    string _ending1;
    string _ending2;

    public FinalChoice(string cA, string choice1, string choice2, string ending1, string ending2, Choice one = null, Choice two = null)
        : base(cA, choice1, choice2, one ?? new Choice("empty", "empty", "empty", null, null), two ?? new Choice("empty", "empty", "empty", null, null))
    {
        _ending1 = ending1;
        _ending2 = ending2;
    }
    public override void OutcomeOne()
    {
        Console.Clear();
        Console.WriteLine(_ending1);
    }

    public override void OutcomeTwo()
    {
        Console.Clear();
        Console.WriteLine(_ending2);
    }
}