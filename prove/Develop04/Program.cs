using System;

class Program
{
    static void Main(string[] args)
    {
        Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Breath breath = new Breath("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string input = "0";

        do 
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n\t1. Start Breathing Activty\n\t2. Start reflecting activity\n\t3. Start listing actvity\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                breath.Breathe();
            }
            else if (input == "2")
            {
                reflection.Relfect();
            }
            else if (input == "3")
            {
                listing.List();
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong!!!");
            }
        }
        while(input != "4");
    }
}