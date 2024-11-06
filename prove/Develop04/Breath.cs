public class Breath : Activity
{
    public Breath(string name, string welcomeMessage)
        :base(name, welcomeMessage)
    {}

    public void Breathe()
    {
        Welcome();
        int seconds = GetSeconds();

        Console.Clear();

        int rounds = seconds/9;

        Console.WriteLine("Get Ready!");
        Animation(5);
        Console.WriteLine("");

        for (int i=rounds; i > 0; i--)
        {
            NumberAnimation("Breath in....", 4);
            Console.WriteLine("");
            NumberAnimation("Breath out....", 5);
            Console.WriteLine("\n\n");

        }

        Goodbye(seconds);

    }
}