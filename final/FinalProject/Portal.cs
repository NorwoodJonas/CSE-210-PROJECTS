class Portal : GenericThing
{ //A GenericThing that when used will move player to a different area
    public int areaName;

    public Portal(Commanding c) : base(c)
    {

    }
    public override void Use()
    {
        commands.ChangeArea(areaName);
    }
}