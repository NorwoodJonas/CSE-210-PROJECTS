class Goal
{
    protected int points;
    protected string goal;
    protected bool completed = false;

    public Goal(string goal, int points)
    {
        this.goal = goal;
        this.points = points;
    }

    public Goal(string goal, int points, bool completed)
    {
        this.goal = goal;
        this.points = points;
        this.completed = completed;
    }

    public Goal()
    {
    }

    public string GetGoal()
    {
        return goal;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public int GetPoints()
    {
        return completed?points:0;
    }

    public List<string> GetSaveString()
    {
        List<string> thing = new(); //(goal,points.ToString(),(completed?"true":"false"));
        thing.Add(goal);
        thing.Add("~" + points.ToString());
        thing.Add("~" + (completed?"true":"false"));

        return thing;
    }

    public string GoalDisplay()
    {
        return $"[{(completed?"x":" ")}] {goal}";
    }

    public void Complete()
    {
        completed = true;
    }
}