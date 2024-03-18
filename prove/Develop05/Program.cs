using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---TerminalGoals version 8.3.3---");
        Console.WriteLine("Making object things");
        List<Goal> goals = new();
        //Dictionary<string, Goal> goals = new(); //maybe don't use a dictionary
        // Menu ez = new(); I was making a menu class, but apparently that is a lot of work
        // ez.AddCommand("Add-Goal", AddGoal, "Adds a goal");
        // ez.AddCommand("Complete-Goal", CompleteGoal, "Allows you to check off a goal");
        // ez.AddCommand("Examine-Goal", ExamineGoals, "Displays a list of goals and the points");

        // ez.StartMenu();
        int x = 1;
        bool quit = false;
        string temp = "";
        string[] temper;
        while(!quit)
        {
            Console.Write("Type help for commands\n-");
            temp = Console.ReadLine();
            temper = temp.Split();
            if(temper[0] == "") //display
            {
                //Display goals
                
                foreach(Goal g in goals)
                {
                    Console.WriteLine($"{0}.{1}", x, g.GoalDisplay());
                    x++;
                }
                x = 0;
                foreach(Goal g in goals)
                {
                    x += g.GetPoints();
                }
                Console.WriteLine($"Total points: {x}");
                x = 1;
            }
            else if(temper[0] == "") //create goalType goal points (completionNumber bonusPoints) //last only for a checklist goal
            {
                //Add goal
                if(temper[1] == "normal")
                {
                    goals.Add(new Goal(temper[2], int.Parse(temper[3])));
                }
                else if(temper[1] == "eternal")
                {
                    goals.Add(new Eternal(temper[2], int.Parse(temper[3])));
                }
                else if(temper[1] == "checklist")
                {
                    goals.Add(new Checklist(temper[2], int.Parse(temper[3]), int.Parse(temper[4]), int.Parse(temper[5])));
                }
            }
            else if(temper[0] == "") //complete goalNumber
            {
                x = int.Parse(temper[1]); //Wow, great design reusing variables to save memory
                //Complete goal
                goals[x].Complete();
                x = 1;
            }
            else if(temper[0] == "") //save filepath
            {
                //Save Goals and such
                foreach(Goal g in goals)
                {
                    File.AppendAllLines(temper[1], g.GetSaveString());
                }
            }
            else if(temper[0] == "") //load filepath
            {
                //Load Goals
                
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
}