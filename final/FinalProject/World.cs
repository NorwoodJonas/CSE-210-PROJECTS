class World
{ //should contain a list of areas, and things affecting area
    private int time = 0; //time, goes between cycles of 86,400 per day
    private List<Area> areas = new();
    public Area activeArea;

    public PlayerCharacter pc = new(); //need to fix this

    public World(Area a)
    {
        areas.Add(a);
        activeArea = a;
    }

    public void AddArea(Area a)
    {
        areas.Add(a);
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