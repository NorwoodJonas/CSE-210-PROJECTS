class Journal
{
    private LinkedList<string>  entries;

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

    public LinkedList<string> Texted()
    {
        return entries;
    }
}