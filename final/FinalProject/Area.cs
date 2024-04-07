class Area //should contain list of items, a description, atmosphere, and such
{
    public List<GenericThing> thingsInArea; //I need to access these things, don't blame me
    private string areaName;
    private string areaDesc;

    public Area()
    {
        areaName = "VOID";
        areaDesc = "There is nothing here, the programmer was too lazy to actually make an area.";
    }

    public Area(string name, string desc)
    {
        areaName = name;
        areaDesc = desc;
        thingsInArea = new List<GenericThing>();
        thingsInArea.Add(new GenericThing("Nothing"));
    }

    public Area(string name, string desc, List<GenericThing> things)
    {
        areaName = name;
        areaDesc = desc;
        thingsInArea = things;
    }

    public string DescribeArea()
    {
        string temp = areaDesc + ":";
        foreach(GenericThing things in thingsInArea)
        {
            temp += things.DescribeGenericThing() + ", ";
        }
        return temp;
    }

    public void PlaceThing(GenericThing g)
    {
        thingsInArea.Add(g);
    }
}