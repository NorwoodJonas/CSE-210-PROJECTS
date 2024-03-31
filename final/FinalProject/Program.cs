using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---PoorMansGamesV1.1---");
        Console.WriteLine("Initializing objects");
        Commanding commands = new();
        bool done = false;
        string input = "";
        string[] whatever;
        while(!done)
        {
            input = Console.ReadLine();
            whatever = input.Split();
            Commanding.Do(whatever);
        }
    }
}