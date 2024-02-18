using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Scripture Power V20.12---");
        Console.WriteLine("Allocating memory...");
        string quitter = "";
        Reference referee = new("Matthew", 5, 12, 13); //@ makes this a string literal where you don't need escape charecters
        Scripture scripted = new("Rejoice, and be exceeding glad: for great is your reward in heaven: for so persecuted they the prophets which were before you. Ye are the asalt of the earth: but if the salt have lost his savour, wherewith shall it be salted? it is thenceforth good for nothing, but to be cast out, and to be trodden under foot of men.", referee);
        Console.WriteLine("Done."); //This is long because I don't want to use @ because it includes newlines, and I don't want that because I tried a thing... Nevermind.
        Console.WriteLine("Starting program loop...");
        Console.WriteLine("Clearing screen...");

        do
        {
            Console.Clear();
            scripted.ReadScripture();
            Console.WriteLine("\nEnter or quit");
            quitter = Console.ReadLine();
            if(quitter == "quit") return;
        } while(scripted.HideWords(3));
        if(quitter != "quit")
        {
            Console.Clear();
            scripted.ReadScripture(); //This is a lazy way to display one more time
            Console.WriteLine("Enter");
            quitter = Console.ReadLine();
        }
        Console.WriteLine("Ending program...");
    }
}