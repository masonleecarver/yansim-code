public class Activity
{
    private string _name;
    private string _welcomeMessage;

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
        // int cursorPos = Console.CursorTop;
        bool toggle = true;

        for (int i = seconds; i >  0; i--)
        {
            // Console.SetCursorPosition(0, cursorPos);
            Console.Write(toggle ? "⤡" : "⤢");
            Thread.Sleep(500);
            Console.Write("\b");
            toggle = !toggle;
        }

    }

    public void NumberAnimation(string starter, int seconds)
    {

        int cursorPos = Console.CursorTop;

        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(0, cursorPos);
            if (seconds <= 1)
            {
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorPos);
                Console.Write(starter);
            }
            else
            {
                Console.Write($"{starter} {seconds}");
            }
            Thread.Sleep(1000);
            seconds -= 1;
        }
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