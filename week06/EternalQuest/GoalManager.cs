using System;


class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
    }

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine($"\nScore: {_score}  |  Level: {_level}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
            }
        } while (choice != 6);
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select goal type:\n1. Simple\n2. Eternal\n3. Checklist");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"Congratulations! You earned {earned} points.");
            CheckLevelUp();
        }
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 You leveled up! Level {_level} achieved!");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved file found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
        }
        Console.WriteLine("Goals loaded.");
    }
}
