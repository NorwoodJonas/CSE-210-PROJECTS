class Job
{
    public string _company;
    public string _title;
    public int _startYear;
    public int _endYear;
    public void DisplayJob()
    {
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
    public void SetJob(string t, string c, int sy, int ey)
    {
        _company = c;
        _title = t;
        _startYear = sy;
        _endYear = ey;
    }
}