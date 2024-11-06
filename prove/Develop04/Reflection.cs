public class Reflection : Activity
{
    private List<string> _prompt = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    static List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    private Random random = new();

    private List<string> _questionCopy = _questions;

    public Reflection(string name, string welcomeMessage)
        :base(name, welcomeMessage)
    {}

    public string Question()
    {
        if (_questionCopy.Count <= 0)
        {
            _questionCopy = _questions;
        }
        string question = _questionCopy[random.Next(_questionCopy.Count)];
        _questionCopy.Remove(question);
        return question;
    }

    public void Relfect()
    {
        Welcome();
        int seconds = GetSeconds();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(5);
        string prompt = _prompt[random.Next(_prompt.Count)];
        Console.Write($"\n Consider the following prompt:\n --- {prompt} ---\nWhen you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        Console.WriteLine("\n");
        int rounds = seconds/8;
        NumberAnimation("You may begin in...", 5);
        Console.WriteLine("\n");
        for (int i = rounds; i > 0; i--)
        {
            Console.Write(Question());
            Countdown(8);
            Console.WriteLine("");
        }

        Console.WriteLine("");

        Goodbye(seconds);
    }
}