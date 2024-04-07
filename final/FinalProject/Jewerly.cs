using System.Diagnostics.Tracing;
using System.Security.AccessControl;

class Jewerly : GenericThing
{ //A GenericThing that adjusts character stats
    List<string> usefulness;
    Random ran = new();
    private int level;

    public Jewerly(int l)
    {
        usefulness.Add($"The {name} shines with brilliant lustre...");
        usefulness.Add($"You can't helped but be entranced by the {name}");
        usefulness.Add($"The {name} tempts you");
        usefulness.Add($"I paid too much for this {name}");
        usefulness.Add($"I think this {name} is fake");
        usefulness.Add($"The {name} gives you 14k worth of vision... supposedly.");
        level = l;
    }

    public override void Use()
    {
        int index = ran.Next(0, usefulness.Count);
        Console.WriteLine(usefulness[index]);
    }

    public int Held()
    {
        return level;
    }
}