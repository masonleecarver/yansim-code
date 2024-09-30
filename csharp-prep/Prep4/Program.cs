using System;

class Program
{
    static void Main(string[] args)
    {
        string numberStr;
        int number;
        List<int> numbers;
        numbers = new();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            numberStr = Console.ReadLine();
            number = Int32.Parse(numberStr);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);

        int total = 0;
        int largest = 0;
        int smallest = 999999999;

        foreach (int num in numbers)
        {
            total += num;
            if (num > largest)
            {
                largest = num;
            }
            if (num < smallest && num > 0)
            {
                smallest = num;
            }
        }

        float average = ((float)total) / numbers.Count();

        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number is {smallest}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}