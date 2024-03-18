using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Numerics;

class Eternal : Goal
{
    private int timesCompleted = 0;

    public Eternal(string goal, int points) : base(goal, points)
    {
    }

    public Eternal(string goal, int points, int timesCompleted) : base(goal, points)
    {
        this.timesCompleted = timesCompleted;
    }

    public new int Complete() //I have no idea what new does here, TBH
    {
        timesCompleted++;
        return points;
    }

    public new int GetPoints()
    {
        return timesCompleted * points;
    }

    public new string GoalDisplay()
    {
        return $"[{timesCompleted}] {goal}";
    }

    public new string GetSaveString()
    {
        return goal + "~" + points.ToString() + "~" + timesCompleted.ToString();
    }
}