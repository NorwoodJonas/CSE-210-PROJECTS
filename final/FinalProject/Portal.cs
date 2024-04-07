class Portal : GenericThing
{ //A GenericThing that when used will move player to a different area
    public int areaAccess = 0;

    public Portal(Commanding c, int areaConnector, string name, string desc, string location) : base(c, name, desc, location)
    {
        areaNumber = areaConnector;
    }
    public override void Use()
    {
        commands.ChangeArea(areaAccess);
    }
}