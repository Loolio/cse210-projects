using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.GetPoints();

            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetPoints();
            }
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore() => Console.WriteLine($"Score: {_score}");

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            switch (type)
            {
                case "Simple":
                    var simple = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.TryParse(data[3], out bool isComplete) && isComplete)
                        simple.RecordEvent();
                    _goals.Add(simple);
                    break;

                case "Eternal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;

                case "Checklist":
                    var checklist = new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                                                      int.Parse(data[3]), int.Parse(data[5]));
                    checklist.CurrentCount = int.Parse(data[4]);
                    _goals.Add(checklist);
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}

