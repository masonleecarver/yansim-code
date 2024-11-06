using System;
using System.IO;
using System.Linq;

public class Journal {

    public List<string> _entryList = new();
    string _path = "";

    public void SaveFile()
    {

        Console.Write("What do you want the file to be called? (do not include .txt - will save in same folder)\n");
        string path = Console.ReadLine();
        _path = $"{path}.txt";

        using (StreamWriter sw = File.AppendText(path))
        {
            if (_entryList.Count > 0)
            {
                foreach (string entry in _entryList)
                {
                    sw.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("No entries to write.");
            }
            
        }

        _entryList = [];

        Console.WriteLine("File saved successfully :). All previous entries cleared.");

    }

    public void LoadFile()
    {
        Console.Write("Which file would you like to load?\n");
        _path = Console.ReadLine();

        try
        {
            StreamReader sr = new StreamReader($"{_path}");

        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File doesn't exist.");
            _path = "";
        }

        catch (Exception)
        {
            foreach(string entry in _entryList)
            {
                Console.WriteLine(entry);
            }
            _path = "";
        }
    }

    public List<string> DiplayReadiness()
    {

        try
        {
            StreamReader sr = new StreamReader($"{_path}");

            string line = sr.ReadLine();
            List<string> loadedEntries = new();

            while (line != null)
            {

                loadedEntries.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return loadedEntries;
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File doesn't exist.");
            return [];
        }

        catch (Exception)
        {
            Console.WriteLine("Something else isn't right here.");
            return [];
        }


    }

    public void DisplayLast()
    {
        if (_entryList.Count > 0)
        {
           Console.WriteLine(_entryList.Last()); 
        }
        else
        {
            Console.WriteLine("No entries to show.");
        }
    }

    public void Display(Journal journal)
    {
        try
        {
            List<string> loadedEntries = journal.DiplayReadiness();

            if (loadedEntries.Count > 0)
            {
                foreach (string entry in loadedEntries)
                {
                    Console.WriteLine(entry);
                } 
            }
            else
            {
                Console.WriteLine("No entries to show.");
            }
        }

        catch (Exception)
        {
            if (_entryList.Count > 0)
            {
                foreach (string entry in _entryList)
                {
                    Console.WriteLine(entry);
                }
            }
            else 
            {
                Console.WriteLine("Nothing to show.");
            }
        }
    }
 
}


