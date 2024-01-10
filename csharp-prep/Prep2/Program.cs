using System;
using System.Net.WebSockets;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("Enter your grade percentage: ");
        String percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        int final = 0;

        if(percent >= 90)
        {
            letter = "A";
        }
        else if(percent >= 80)
        {
            letter = "B";
        }
        else if(percent >= 70)
        {
            letter = "C";
        }
        else if(percent >= 60)
        {
            letter = "D";
        }
        else if(percent < 60)
        {
            letter = "F";
        }
        final = percent % 10;
        Console.Write($"You got a {letter}");
        if(percent < 97 && percent >= 60)
        {
            if(final >= 7)
            {
                Console.Write("+");
            }
            else if(final < 3)
            {
                Console.Write("-");
            }
        }
        Console.WriteLine();
        if(percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
    }
}