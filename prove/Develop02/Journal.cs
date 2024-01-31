class Journal
{
    private LinkedList<string>  entries;

    public Journal()
    {
        entries = new LinkedList<string>();
    }

    public void Write(string entry)
    {
        entries.AddLast(entry);
    }

    public void Disp()
    {
        foreach(string ent in entries)
        {
            Console.WriteLine($"{ent}");
        }
    }

    public void Stuff(LinkedList<string> x) //because you are stuffing a journal full of... stuff
    {
        entries = x;
    }

    public LinkedList<string> Texted()
    {
        return entries;
    }
}