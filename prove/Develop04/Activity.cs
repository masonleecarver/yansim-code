using System.Timers;

public class Activity
{
    private string _name;
    private string _welcomeMessage;

    private bool _timeUp = false;

    public Activity(string name, string welcomeMessage)
    {
        _name = name;
        _welcomeMessage = welcomeMessage;
    }

    public int GetSeconds()
    {
        Console.Write("How long would you like to do the activity? ");
        return Int32.Parse(Console.ReadLine());
    }

    public void Animation(int seconds)
    {

        for (int i = seconds; i >  0; i--)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }

    }

    public void NumberAnimation(string starter, int seconds)
    {

        int cursorPos = Console.CursorTop;

        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(0, cursorPos);
            Console.Write($"{starter} {seconds}");
            Thread.Sleep(1000);
            seconds -= 1;
        }
    }
    public void Countdown(int seconds)
    {
        _timeUp = false;

        for (int i = seconds; i > 0; i--)
        {
            Thread.Sleep(1000);
        }
        
        _timeUp = true;

    }


    public bool TimeUp()
    {
        return _timeUp;
    }

    public void Welcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_welcomeMessage}\n");
    }

    public void Goodbye(int seconds)
    {
        Animation(5);
        Console.Write($"\n\nWell done!!\n\nYou have completed another {seconds} seconds of the {_name}.\n");
        Animation(5);
    }

}