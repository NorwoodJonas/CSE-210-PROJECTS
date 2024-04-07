using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---PoorMansGamesV1.1---");
        Console.WriteLine("Initializing world");
        Area a = new();
        World w = new(a);
        WordReference dic = new();
        Commanding commands = new(dic, w);
        bool done = false;
        string input = "";
        string[] whatever;
        while(!done)
        {
            input = Console.ReadLine();
            whatever = input.Split();
            commands.Do(whatever);
        }
    }
}