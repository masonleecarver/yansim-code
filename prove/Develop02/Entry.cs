using System.Security.Cryptography.X509Certificates;

public class Entry 
{
    static string note = "";
    static string prompt = "";
    static DateTime dateTime = DateTime.UtcNow.Date;
    static string date = dateTime.ToString("MM/dd/yyyy");

    public void GetNote() 
    {
        note = "";
        Promts obj = new();
        prompt = obj.RandomPrompt();
        Console.Write($"{prompt}\n");
        note = Console.ReadLine();
        note = $"{date}\nPrompt: {prompt}\n{note}\n";
    }

    public void AddToList(Journal journal)
    {
        string newEntry = note;
        List<string> list = journal.entryList;
        list.Add(newEntry);

    }

}