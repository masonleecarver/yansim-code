using System.Security.Cryptography.X509Certificates;

public class Entry 
{
    static string _note = "";
    static string _prompt = "";
    static DateTime _dateTime = DateTime.UtcNow.Date;
    static string _date = _dateTime.ToString("MM/dd/yyyy");

    public void GetNote() 
    {
        _note = "";
        Promts obj = new();
        _prompt = obj.RandomPrompt();
        Console.Write($"{_prompt}\n");
        _note = Console.ReadLine();
        _note = $"{_date}\nPrompt: {_prompt}\n{_note}\n";
    }

    public void AddToList(Journal journal)
    {
        string newEntry = _note;
        List<string> list = journal._entryList;
        list.Add(newEntry);

    }

}