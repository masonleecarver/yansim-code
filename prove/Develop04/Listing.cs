using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Listing : Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    private Random random = new();

    private List<string> writtenEntries = new();

    public Listing(string name, string welcomeMessage)
        :base(name, welcomeMessage)
    {}

    public void List()
    {
        Welcome();
        int seconds = GetSeconds();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation(5);
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        NumberAnimation("\nYou may begin in...", 5);
        Console.WriteLine("\n");
        Parallel.Invoke(
            () => Countdown(seconds),
            () => {
                while (TimeUp() != true)
                {
                WriteEntries(); 
                }
            }
        );
        Console.WriteLine($"Congrats! You wrote {writtenEntries.Count} entires.");
        writtenEntries.Clear();
        Goodbye(seconds);
    }

    public void WriteEntries()
    {
        Console.Write("> ");
        string entry = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entry))
        {
            writtenEntries.Add(entry); 
        }  
    }

}