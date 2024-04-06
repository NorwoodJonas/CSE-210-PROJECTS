class World
{ //should contain a list of areas, and things affecting area
    private int time = 0; //time, goes between cycles of 86,400 per day
    private List<Area> areas;
    public Area activeArea;

    public Character pc;

    public World()
    {
    }

    public void AddArea()
    {

    }

    public void SetTime(int x)
    {
        time = x;
    }

    public void SetTime(int x, bool b)
    {
        if(b)
        {
            time += x;
        }
        else
        {
            time -= x;
        }
    }

    public int GetTime()
    {
        return time;
    }

    public void SetActive(int x)
    {
        activeArea = areas[x];
    }
}