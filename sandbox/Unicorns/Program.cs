namespace Unicorns;

class Program
{
    static void Main(string[] args)
    {

        Random rand = new();
        int d1 = rand.Next(1,7);
        int d2 = rand.Next(1,7);
        int d3 = rand.Next(1,7);

        List <int> diceList = [d1, d2, d3];
        diceList = diceList.Sort();

        foreach (int die in diceList)
        {
            Console.WriteLine($"{die}");
        } 

    }
}
