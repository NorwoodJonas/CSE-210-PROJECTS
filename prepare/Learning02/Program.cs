using System;
using System.Net.Http.Headers;

class Program
{
    
    static void Main(string[] args)
    {
        Resume myResume = new();
        myResume._name = "John Doe";
        myResume.AddJob("Worker", "Company", 1999, 2009);
        myResume.AddJob("Bench Warmer", "Jets", 2010, 2023);

        myResume.DisplayResume();
    }
}