using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---TerminalGoals version 8.3.3---");
        Console.WriteLine("Making object things");
        Dictionary<string, Goal> goals = new(); //maybe don't use a dictionary
        // Menu ez = new(); I was making a menu class, but apparently that is a lot of work
        // ez.AddCommand("Add-Goal", AddGoal, "Adds a goal");
        // ez.AddCommand("Complete-Goal", CompleteGoal, "Allows you to check off a goal");
        // ez.AddCommand("Examine-Goal", ExamineGoals, "Displays a list of goals and the points");

        // ez.StartMenu();
        bool quit = false;
        string temp = "";
        string[] temper;
        while(!quit)
        {
            Console.Write("Type help for commands\n-");
            temp = Console.ReadLine();
            temper = temp.Split();
            if(temper[0] == "")
            {
                //
            }
            else if(temper[0] == "")
            {
                //
            }
            else if(temper[0] == "")
            {
                //
            }
            else if(temper[0] == "")
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

    public static void AddGoal()
    {
        return;
    }

    public static void CompleteGoal()
    {
        return;
    }

    public static void ExamineGoals()
    {
        return;
    }
}