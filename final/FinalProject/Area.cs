class Area //should contain list of items, a description, atmosphere, and such
{
    private List<GenericThing> thingsInArea;
    private string areaName;
    private string areaDesc;

    public Area()
    {
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

    public void placeThing()
    {
        
    }
}