using System.Runtime.CompilerServices;

class Checklist : Goal
{
    private int timesCompleted;
    private int completionGoal;
    private int bonusPoints; //probably use as normal points as points just resolves once

    public Checklist(string goal, int points, int bonusPoints, int timesWantToComplete) : base(goal, points)
    {
        this.bonusPoints = bonusPoints;
        completionGoal = timesWantToComplete;
    }

    public Checklist(string goal, int points, int bonusPoints, int timesCompleted, int compGoal)
    {
        this.points = points;
        this.goal = goal;
        this.bonusPoints = bonusPoints;
        this.timesCompleted = timesCompleted;
        completionGoal = compGoal;
        if(completionGoal == timesCompleted)
        {
            completed = true;
        }
    }

    public new int Complete() //I have no idea what new does here, TBH
    {
        if(completed == true) //wow, great code practice
        {
            return 0;
        }
        else
        {
            if(timesCompleted < (completionGoal - 1)) //Do I want this - 1?
            {
                timesCompleted++;
                return points;
            }
            else //I really hope nobody tries completing a completed goal.
            {
                timesCompleted++;
                completed = true;
                return bonusPoints + points;
            }
        }
    }

    public new int GetPoints()
    {
        return timesCompleted * points + (completed?bonusPoints:0);
    }

    public new string GoalDisplay()
    {
        return $"[{timesCompleted}//{completionGoal}] {goal}";
    }

    public new string GetSaveString()
    {
        return goal + "~" + points.ToString() + "~" + bonusPoints.ToString() + "~" + timesCompleted.ToString() + "~" + completionGoal.ToString();
    }
}