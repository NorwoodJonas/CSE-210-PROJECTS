using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Scripture Power V20.12---");
        Console.WriteLine("Allocating memory...");
        string quitter = "";
        Reference referee = new("Matthew", 5, 12, 13); //@ makes this a string literal where you don't need escape charecters
        Scripture scripted = new(@"Rejoice, and be exceeding glad: for
great is your reward in heaven: for so 
persecuted they the prophets which 
were before you. Ye are the asalt of the earth: 
but if the salt have lost his savour, 
wherewith shall it be salted? it is thenceforth 
good for nothing, but to be cast out, 
and to be trodden under foot of men.", referee);
        Console.WriteLine("Done.");
        Console.WriteLine("Starting program loop...");
        Console.WriteLine("Clearing screen...");
        Console.Clear();

        do
        {
            scripted.ReadScripture();
            Console.WriteLine("Enter or quit");
            quitter = Console.ReadLine();
            if(quitter == "quit") return;
        } while(scripted.HideWords(3));
        Console.WriteLine("Ending program..."); //Display one more time before this
    }
}