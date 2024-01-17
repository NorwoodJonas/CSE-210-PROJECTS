using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        Console.Write("---Magic number guesser v1.1---");
        int magic = generator.Next(1, 100);
        int x = 0;
        do
        {
            Console.Write("\nGuess: ");
            x = int.Parse(Console.ReadLine());
            if(x > magic)
            {
                Console.Write("Lower...");
            }
            else if(x < magic)
            {
                Console.Write("Higher...");
            }
        } while(x != magic);
        Console.WriteLine("\nYou got it.");
    }
}