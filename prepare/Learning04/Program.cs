using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Mason Carver", "Mtn Dew-ology");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Mason Carver", "Math... gross", "69", "4-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mason Carver", "I LOVE WRITING!!!", "The Day I Became A Snail... and Ate a Worm.");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}