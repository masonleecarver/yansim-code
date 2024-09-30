using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new();

    public void Display()
    {
        Console.WriteLine(_name);

        foreach (Job job in _jobs)
        {
            job.Disaply();
        }
    }
}