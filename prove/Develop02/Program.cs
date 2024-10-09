using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        string choice = "0";
        string options = "1) Write an entry\n2) Display Entries\n3) Save File\n4) Load File\n5) Quit";

        Entry entry = new();
        Journal journal = new();


        do 
        {
            Console.WriteLine(options);
            Console.Write("");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                entry.GetNote();
                entry.AddToList(journal);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                journal.SaveFile();
            }
            else if (choice == "4")
            {
                journal.LoadFile();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Remember to write in your jounral every day.\n");
                break;
            }
            else
            {
                Console.WriteLine("What?");
            }

        }
        while (choice != "5");
    }
}