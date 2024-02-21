class Assignment
{
    protected string sName;
    protected string topic;

    public Assignment(string name, string topic)
    {
        sName = name;
        this.topic = topic;
    }

    public string GetSummary()
    {
        return sName + ":" + topic;
    }
}

class MathAssignment:Assignment
{
    private string section;
    private string problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        this.section = section;
        this.problems = problems;
    }

    public string GetHomeworkList()
    {
        return "Section " + section + ":" + problems;
    }
}

class WritingAssignment: Assignment
{
    private string title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        this.title = title;
    }

    public string GetWritingInformation()
    {
        return title;
    }
}