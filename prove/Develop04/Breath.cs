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

        int rounds = seconds/12;

        Console.WriteLine("Get Ready!");
        Animation(5);
        Console.WriteLine("");

        for (int i=rounds; i > 0; i--)
        {
            NumberAnimation("Breath in....", 4);
            Console.WriteLine("");
            NumberAnimation("Hold....", 4);
            Console.WriteLine("");
            NumberAnimation("Breath out....", 4);
            Console.WriteLine("\n");

        }

        Goodbye(seconds);

    }
}