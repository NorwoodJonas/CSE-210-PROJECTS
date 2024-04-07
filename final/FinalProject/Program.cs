using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---PoorMansGamesV1.1---");
        Console.WriteLine("Initializing world");
        List<GenericThing> itemsInArea= new();
        Area a = new("weird hill","There is a tree on this weird hill, it would be a good place to die on.");
        Area b = new("grassy knoll","This knoll seems suspicously [sic] grassy.");
        Area c = new("sacred grove","Oh how lovely was the morning...");
        Area d = new("small town","This town is really quite small.");
        Area e = new("","");
        Area f = new("","");
        Area g = new("","");
        World w = new(a);
        w.AddArea(b);
        w.AddArea(c);
        w.AddArea(d);
        w.AddArea(e);
        w.AddArea(f);
        w.AddArea(g);
        WordReference dic = new();
        Commanding commands = new(dic, w);
        string input = "";
        string[] whatever;
        input = Console.ReadLine();
        whatever = input.Split();
        while(commands.Do(whatever))
        {
            input = Console.ReadLine();
            whatever = input.Split();
        }
    }
}