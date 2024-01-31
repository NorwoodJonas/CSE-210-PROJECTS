class Menu
{
    private string name;
    private Journal j;

    FoolishDesign fool = new();

    public Menu(string name, Journal j)
    {
        this.name = name;
        this.j = j;
    }

    public void ShowMenu()
    {
        Console.WriteLine($"---{name}---");
        Console.WriteLine("1. ");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");
        Console.WriteLine("4. ");
        Console.WriteLine("5. ");
    }

    public bool Option()
    {
        int x = int.Parse(Console.ReadLine());
        if(x == 1) {Entry(); return true;};
        if(x == 2) {Show(); return true;};
        if(x == 3) {Save(); return true;};
        if(x == 4) {Load(); return true;};
        if(x == 5) {return Quit();};
        return true;
    }

    private void Entry()
    {
        Console.WriteLine("Write whatever, type \".\" on a newline to quit");
        string entry = fool.Date();
        entry += "\n" + fool.Prompt();
        Console.WriteLine(entry);
        string e = "";
        do
        {
            e = Console.ReadLine();
            entry += "\n" + e;
        } while(e != "\".\"");
        j.Write(entry);
    }

    private void Show()
    {
        j.Disp();
    }

    private void Save()
    {
        Console.Write("Enter filename: ");
        string pathy = Console.ReadLine();
        File.AppendAllLines(pathy, j.Texted());
    }

    private void Load()
    {
        Console.Write("Enter file to load: ");
        string pathy = Console.ReadLine();
        j.Stuff(new LinkedList<string>(File.ReadAllLines(pathy))); //https://stackoverflow.com/questions/3167971/how-can-i-transform-or-copy-an-array-to-a-linked-list
                                                                    //Should I really reference for one command?
    }

    private bool Quit()
    {
        Console.WriteLine("Are you sure? y/n");
        string fleeting = Console.ReadLine();
        if(fleeting == "y")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Good.");
            return true;
        }
    }
}