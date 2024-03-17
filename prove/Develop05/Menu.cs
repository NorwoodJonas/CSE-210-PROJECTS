/*
*   Menu class V 1.0
*       -Makes menu creation slightly easier
*       -You just add methods to this object that take strings, then you can call them using arrays of string gotten from the user
*       -using String.Parse()
*
*       Future Goals:
*           -Allow auto parsing of input arrays so users can define normal functions without worrying about strings (try using object[])
*           -Get rid of the need to do new Action() everytime, make it so you can do something like:
*                  //Menu.NewFunction(string name)
*                  //{
*                       Define the function to be added
*                  //}
*           -Allow for adding multiple functions as one command: Menu.AddCommand(Action[]);
*           -Should I not force documentation in AddCommand?
*           -Make options for things to look nice, option to clear console after each command?
*/

using System.Formats.Asn1;

class Menu
{
    private Dictionary<string, Delegate> commands; //This is a dictionary of functions
    private Dictionary<string, string> help; //This is just for reference and used by the help command
    private bool quit = false;
    private string temp = "";
    private string[] temper;

    public Menu()
    {
        AddCommand("help", new Action<string>(Help), "helps with stuff"); //Adds help command to list of commands
        AddCommand("quit", new Action(Quit), "Quits the menu loop"); //Probably don't need to do new action, maybe, it should save memory anyway
    }

    public void Quit()
    {
        quit = true;
    }

    public void StartMenu()
    {
        Help("list");
        while(!quit)
        {
            temp = Console.ReadLine();
            temper = temp.Split();
        }
    }

    public void HolyInvocation(string[] commanding) //Since the whole point of this class is to get user input and run functions from it, whoever writes the code better deal with the strings the user passes in themselves
    {
        //if(commands.ContainsKey(command))
        //{
        //    commands[command].DynamicInvoke(suggestions); //worse way to do it
        //}
        if(commands.TryGetValue(commanding[0], out Delegate function))
        {
            function.DynamicInvoke(commanding.Skip(1).ToArray());
        }
        else
        {
            Console.WriteLine("Unknown command");
            Help("");
        }
    }

    public void AddCommand(string command, Delegate action, string description) //Adds a command, need a delegate
    {
        commands.Add(command, action);
        help.Add(command, description);
    }

    public void Help(string command)
    {
        if(command == "")
        {
            Console.WriteLine("Type \"help -command-\" for help on a specific command, or \"help list\" to list commands");
        }
        else if(command == "list")
        {
            //List dictionary keys
        }
        else
        {
            //add error detection
            Console.WriteLine(help[command]);
        }
    }
}