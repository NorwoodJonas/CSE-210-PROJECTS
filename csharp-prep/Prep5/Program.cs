using System;

class Program
{
    static void DisplayMassage()
    {
        Console.WriteLine("Superflous-Use-Of-Functions v1.96.10");
    }

    static string IdentityTheft() //steals some of users personal information for later use
    {
        Console.WriteLine("What is your name?");
        return Console.ReadLine();
    }

    static int SecurityQuestion() //asks a common account security question in order to attempt to gain access to users bank account
    {
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    static int ReinventingTheWheel(int x) //Does something which probably already exists as a function in the C# (Math.Pow() I think)
    {                                       //Also, it would be easier to write x * x than ReinventingTheWheel(x)
        return x * x;
    }

    static void SomethingThatWouldHaveBeenEasierToDoInTheMainLoop(string name, int x) //the variables already exist there
    {
        Console.WriteLine($"{name}, your favorite number squared is {x}");
    }
    static void Main(string[] args)
    {
        DisplayMassage();
        string nom = IdentityTheft();
        int num = SecurityQuestion();
        SomethingThatWouldHaveBeenEasierToDoInTheMainLoop(nom, ReinventingTheWheel(num));
    }
}