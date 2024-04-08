class World
{ //should contain a list of areas, and things affecting area
    private int time = 0; //time, goes between cycles of 86,400 per day
    private List<Area> areas = new(); //Because of the way c# works, _underscoreCamelCase isn't that useful
    public Area activeArea; //Look, I know that you want this to be private, but a function to get active area would just be worse.

    public Character pc; //need to fix this

    public World()
    {
    }

    public World(Area a)
    {
        areas.Add(a);
        activeArea = a;
        pc = new Character(); //change character later
    }

    public void SetActiveCharacter(Character c)
    {
        pc = c;
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