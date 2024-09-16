using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);
        string letterGrade = "N/A";

        if (grade < 60)
        {
            letterGrade = "F";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        else if (grade >= 90)
        {
            letterGrade = "A";
        }

        if (grade % 10 >= 7)
        {
            if (letterGrade != "A" && letterGrade != "F")
            {
                letterGrade = $"{letterGrade}+";
            }
        }
        else if (grade % 10 <= 3)
        {
            if (letterGrade != "A" && letterGrade != "F")
            {
                letterGrade = $"{letterGrade}-";
            }
        }

        Console.WriteLine($"Your grade was a {letterGrade}.");

    }
}