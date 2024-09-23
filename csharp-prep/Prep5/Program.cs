using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            return Int32.Parse(number);
        }

        static int SquareNumber(int number)
        {
            return number*number;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {number}.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int squaredNum = SquareNumber(favNum);
        DisplayResult(name, squaredNum);
    }
}