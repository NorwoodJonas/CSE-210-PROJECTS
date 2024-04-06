class Area //should contain list of items, a description, atmosphere, and such
{
    public List<GenericThing> thingsInArea; //I need to access these things, don't blame me
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