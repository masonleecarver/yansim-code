using System;
using System.IO;
using System.Linq;

public class Journal {

    public List<string> entryList = new();

    public void SaveFile()
    {

        Console.Write("What do you want the file to be called? (do not include .txt - will save in same folder)\n");
        string path = Console.ReadLine();
        path = $"{path}.txt";

        using (StreamWriter sw = File.AppendText(path))
        {
            if (entryList.Count > 0)
            {
                foreach (string entry in entryList)
                {
                    sw.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("No entries to write.");
            }
            
        }

        entryList = [];

        Console.WriteLine("File saved successfully :). All previous entries cleared.");

    }

    public void LoadFile()
    {

        Console.Write("Which file would you like to read?\n");
        string path = Console.ReadLine();

        try
        {
            StreamReader sr = new StreamReader($"{path}");

            string line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadLine();
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File doesn't exist.");
        }
    }

    public void DisplayLast()
    {
        if (entryList.Count > 0)
        {
           Console.WriteLine(entryList.Last()); 
        }
        else
        {
            Console.WriteLine("No entries to show.");
        }
    }

    public void Display()
    {
        if (entryList.Count > 0)
        {
           foreach (string entry in entryList)
            {
                Console.WriteLine(entry);
            } 
        }
        else
        {
            Console.WriteLine("No entries to show.");
        }
    }


}