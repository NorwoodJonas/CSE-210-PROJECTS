class Resume
{
    public string _name;
    private LinkedList<Job> jobs = new LinkedList<Job>();
    public void AddJob(string t, string c, int sy, int ey)
    {
        Job tempJob = new(); //imagine using C# 12.0
        tempJob.SetJob(t, c, sy, ey);
        jobs.AddLast(tempJob);
    }
    public void DisplayResume()
    {
        Console.WriteLine(_name);
        foreach(Job j in jobs)
        {
            j.DisplayJob();
        }
    }
}