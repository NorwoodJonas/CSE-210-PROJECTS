class Goal
{
    protected int points;
    protected string goal;
    protected bool completed = false;

    Goal(string goal, int points)
    {
        this.goal = goal;
        this.points = points;
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

    public string GetSaveString()
    {
        return goal + "~" + points.ToString() + "~" + (completed?"true":"false");
    }

    public string GoalDisplay()
    {
        return $"[{(completed?"x":" ")}] {goal}";
    }
}