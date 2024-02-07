class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("FractionalClassTesting --- Version 0.000.11");
        Factions one = new(1);
        Factions definaultly = new();
        Factions f = new(2, 3);

        Console.WriteLine(one.FrackingTwoSeams());
        Console.WriteLine(one.ActionIntoBubble());
        Console.WriteLine(definaultly.FrackingTwoSeams());
        Console.WriteLine(definaultly.ActionIntoBubble());
        Console.WriteLine(f.FrackingTwoSeams());
        Console.WriteLine(f.ActionIntoBubble());

        Console.WriteLine("changing things");

        f.DenominicronChange(7);
        f.NumeroatorChange(4);

        Console.WriteLine(f.NumbervatorGet());
        Console.WriteLine(f.TheNotMeNotHer____Git());
        Console.WriteLine(f.FrackingTwoSeams());
    }
}