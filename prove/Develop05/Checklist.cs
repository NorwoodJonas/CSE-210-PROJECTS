class Checklist : Goal
{
    private int timesCompleted;
    private int completionGoal;
    private int bonusPoints; //probably use as normal points as points just resolves once

    public Checklist(string goal, int bonusPoints, int timesWantToComplete, int points) : base(goal, points)
    {
        this.bonusPoints = bonusPoints;
    }
}