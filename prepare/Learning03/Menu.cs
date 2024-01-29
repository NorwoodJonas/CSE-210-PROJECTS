class Menu
{
    private string name;
    private Journal j;

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

    public void Option(int x)
    {
        if(x == 1) Write();
        if(x == 2) Show();
        if(x == 3) Save();
        if(x == 4) Load();
        if(x == 5) Quit();
    }

    private void Write()
    {
        Console.WriteLine("Write whatever, type \".\" on a newline to quit");
        string entry = "";
        string e = "";
        do
        {
            e = Console.ReadLine();
            entry += e;
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
    }

    private void Quit()
    {
        Console.WriteLine("Are you sure? y/n");
    }
}