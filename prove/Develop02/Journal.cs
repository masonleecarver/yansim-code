using System;
using System.IO;
using System.Linq;

public class Journal {

    public List<string> entryList = new();

    static DateTime dateTime = DateTime.UtcNow.Date;
    static string date = dateTime.ToString("dd-MM-yyyy");

    public void SaveFile()
    {
        string path = "Journal-File.txt";

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
        StreamReader sr = new StreamReader("Journal-File.txt");

        string line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }

        sr.Close();
        Console.ReadLine();
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
        foreach (string entry in entryList)
        {
            Console.WriteLine(entry);
        }
    }


}