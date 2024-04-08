using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---PoorMansGamesV1.1---");
        Console.WriteLine("Initializing world");
        List<GenericThing> itemsInArea= new();
        Area a = new("weird hill","There is a tree on this weird hill, it would be a good place to die on."); //Using a space causes issues with my code
        Area b = new("grassy knoll","This knoll seems suspicously [sic] grassy.");  //How can I deal with that?
        Area c = new("sacred grove","Oh how lovely was the morning..."); //In the meantime, I can leave it
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
        Character playerC = new(commands);
        a.PlaceThing(new Portal(commands, 1, "north", "to the north you see a grassy knoll", "meow"));
        b.PlaceThing(new Portal(commands, 2, "east", "to the east you see a sacred grove", "meow"));
        c.PlaceThing(new Portal(commands, 3, "west", "to the west you see a small town", "meow"));
        Character emptyC = new(commands, "bob", "A shady looking figure", "leaning against the tree");
        emptyC.setIntroMessage("Sup?");
        a.PlaceThing(emptyC);
        playerC.NewPlayerCharacter();
        w.SetActiveCharacter(playerC);
        commands.Look(new List<string>());
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