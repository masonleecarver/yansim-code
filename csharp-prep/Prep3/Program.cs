using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 10);
        string guessed_number;
        int guess;
        int guesses = 0;

        do
        {
            Console.Write("What is your guess? ");
            guessed_number = Console.ReadLine();
            guess = Int32.Parse(guessed_number);
            
            if (guess > number)
            {
                Console.WriteLine("Lower!!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher!!");
            }
            guesses += 1
        }
        while (guess != number);

        if (guess == number)
        {
           Console.WriteLine("You got it, you smarty smart pants. :)"); 
           Console.WriteLine($"Took you {guesses} guesses.") 
        }

    }
}