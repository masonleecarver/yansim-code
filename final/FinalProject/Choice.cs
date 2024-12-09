public class Choice
{
    protected string _choiceArrival;
    protected string _choice1;
    protected string _choice2;
    protected Choice _outcome1;
    protected Choice _outcome2;

    public Choice(string cA, string choice1, string choice2, Choice one, Choice two)
    {
        _choiceArrival = cA;
        _choice1 = choice1;
        _choice2 = choice2;
        _outcome1 = one;
        _outcome2 = two;
    }

    public string GetArrival()
    {
        return _choiceArrival;
    }
    public virtual void Choose()
    {
        Console.WriteLine($"{_choiceArrival}\n");
        Console.WriteLine($"You have two choices....");
        Thread.Sleep(1000);
        Console.WriteLine($"\n\t1. {_choice1}");
        Thread.Sleep(1000);
        Console.WriteLine($"\t2. {_choice2}\n");
        string input;
        do
        {
            Console.Write("So... what will it be? ");
            input = Console.ReadLine();
            if (input == "1")
            {
                this.OutcomeOne();
                break;
            }
            else if (input == "2")
            {
                this.OutcomeTwo();
                break;
            }
            else if (input == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Try again...");
            }
        }
        while (input != "1" | input != "2");

        Console.Clear();
    }

    public virtual void OutcomeOne()
    {
        _outcome1.GetArrival();
        _outcome1.Choose();
    }

    public virtual void OutcomeTwo()
    {
        _outcome2.GetArrival();
        _outcome2.Choose();
    }
}