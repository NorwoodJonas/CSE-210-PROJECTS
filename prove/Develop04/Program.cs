using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---LastMinuteProgramming V0.0.1---");

        Console.WriteLine("Initializing objects...");
        Breathe breath = new("Welcome to the breathing activity, where you breathe", "You have finished breathing");
        Listing list = new("Welcome to the listing activity, where you list things about how you feel","You have finished listing stuff");
        Reflect reflecter = new("Welcome to the reflection activity, where you think about random questions that appear on screen","You have finished reflecting");
        Console.WriteLine("Done.");


        bool quit = false;
        string temp = "";
        int temper = 0;
        while(!quit)
        {
            Console.Write(@"Choose something:
            1.Breathing
            2.Listing
            3.Reflecting
            4.Quit
            -");
            temp = Console.ReadLine();
            temper = int.Parse(temp);
            if(temper == 1)
            {
                breath.StartActivity();
            }
            else if(temper == 2)
            {
                list.StartActivity();
            }
            else if(temper == 3)
            {
                reflecter.StartActivity();
            }
            else if(temper == 4)
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("I don't understand you.");
            }
        }
        Console.WriteLine("Goodbye...");
    }
}