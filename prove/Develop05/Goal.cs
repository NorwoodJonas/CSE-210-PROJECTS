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

    public virtual int GetPoints()
    {
        return completed?points:0;
    }

    public virtual string GetSaveString()
    {
        return "normal" + "~" + goal + "~" + points.ToString() + "~" + (completed?"true":"false");
    }

    public virtual string GoalDisplay()
    {
        return $"[{(completed?"x":" ")}] {goal}";
    }

    public virtual int Complete()
    {
        completed = true;
        return points;
    }
}