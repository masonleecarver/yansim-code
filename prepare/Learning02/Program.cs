using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1995;
        job1._endYear = 2012;

        Job job2 = new();
        job2._jobTitle = "Child Collector";
        job2._company = "The Society for the Betterment of the Enlightened";
        job2._startYear = 1966;
        job2._endYear = 1996;

        Resume resume1 = new();
        resume1._name = "Mason Carver";
        resume1._jobs = [job1, job2];

        resume1.Display();

    }
}