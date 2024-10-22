// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I have a headache.");
        Bin mybin = new("quarters", 40, (float)0.25);
        mybin.ModifyAmount(+6);
        Console.WriteLine(mybin.TotalValue());
    }
}
