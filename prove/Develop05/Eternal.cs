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

    public new void Complete() //I have no idea what new does here, TBH
    {
        timesCompleted++;
    }

    public new int GetPoints()
    {
        return timesCompleted * points;
    }

    public new string GoalDisplay()
    {
        return $"[{timesCompleted}] {goal}";
    }

    public new List<string> GetSaveString()
    {
        List<string> thing = new(); //(goal,points.ToString(),(completed?"true":"false"));
        thing.Add(goal);
        thing.Add("~" + points.ToString());
        thing.Add("~" + timesCompleted.ToString());

        return thing;
    }
}