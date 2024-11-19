using System.IO;

public class Goals
{
    private List<Goal> _goals = new();
    private int _totalPoints = 0;

    public void DisplayGoals()
    {
        if(_goals.Count <= 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            Console.WriteLine("Your goals are: ");
            for(int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].Display()}");
            }
        }
    }

    public void MakeGoal()
    {

        Console.WriteLine("The types of goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\n\t4. Return");
        Console.Write("What kind of goal do you want to make?: ");
        string input = Console.ReadLine();

        if(input == "1")
        {
            SimpleGoal goal = new SimpleGoal();
            goal.SetGoal();
            _goals.Add(goal);
        }
        else if(input == "2")
        {
            EternalGoal goal = new EternalGoal();
            goal.SetGoal();
            _goals.Add(goal);
        }
        else if(input == "3")
        {
            ChecklistGoal goal = new ChecklistGoal();
            goal.SetGoal();
            goal.SetRoundsAndFinalPoints();
            _goals.Add(goal);
        }
        else if(input == "4")
        {
            return;
        }
        else
        {
            Console.WriteLine("Something went wrong...");
        }
    }

    public void CompleteGoals(Goals para)
    {

        List<Goal> uncomplete = _goals.Where(goal => !goal.Completed()).ToList();

        if(uncomplete.Count <= 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            Console.WriteLine("The goals are: ");
            for(int i = 0; i < uncomplete.Count; i++)
            {
                Console.WriteLine($"\t{i+1}. {uncomplete[i].GetName()}");
            }
            Console.Write("Which goal did you complete?: ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            uncomplete[choice].EndMessage(para);

        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You currently have {_totalPoints} points.\n");
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void RemovePoints(int points)
    {
        _totalPoints -= points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    
    public void Save()
    {
        Console.Write("What will the name of the file be?: ");
        using (StreamWriter file = new StreamWriter(Console.ReadLine()))
        {
            file.WriteLine(_totalPoints);
            foreach(Goal goal in _goals)
            {
                if(goal is ChecklistGoal checklistGoal)
                {
                    file.WriteLine($"{goal.GetClass()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.Completed()},{checklistGoal.GetFinalPoints()},{checklistGoal.GetRounds()},{checklistGoal.GetDone()}");
                }
                else
                {
                    file.WriteLine($"{goal.GetClass()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.Completed()}");
                }
            }
        }

        _goals.Clear();
        _totalPoints = 0;
    }

    public void Load()
    {
        Console.Write("What is the name of the file you would like to read? ");
        string[] lines = System.IO.File.ReadAllLines(Console.ReadLine());

        _totalPoints += Int32.Parse(lines[0]);

        for(int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(',');

            if(parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal();
                goal.LoadAGoal(parts[1], parts[2], Int32.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if(parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal();
                goal.LoadAGoal(parts[1], parts[2], Int32.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if(parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal();
                goal.LoadAGoal(parts[1], parts[2], Int32.Parse(parts[3]), bool.Parse(parts[4]));
                goal.LoadInfo(Int32.Parse(parts[5]), Int32.Parse(parts[6]), Int32.Parse(parts[7]));
                _goals.Add(goal);
            }
        }


    }


}