class Checklist : Goal
{
    private int timesCompleted;
    private int completionGoal;
    private int bonusPoints; //probably use as normal points as points just resolves once

    public Checklist(string goal, int bonusPoints, int timesWantToComplete, int points) : base(goal, points)
    {
        this.bonusPoints = bonusPoints;
    }

    public new void Complete() //I have no idea what new does here, TBH
    {
        if(completed == true) //wow, great code practice
        {
        }
        else
        {
        if(timesCompleted < (completionGoal - 1)) //Do I want this - 1?
        {
          timesCompleted++;
        }
        else //I really hope nobody tries completing a completed goal.
        {
            timesCompleted++;
            completed = true;
        }
        }
    }

    public new int GetPoints()
    {
        return timesCompleted * points + (completed?bonusPoints:0);
    }

    public new string GoalDisplay()
    {
        return $"[{timesCompleted}/{completionGoal}] {goal}";
    }
}