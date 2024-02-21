using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment basic = new("John", "Existense [sic]");
        MathAssignment mathful = new("Acts", "Integrals", "1.9", "10-22");
        WritingAssignment writ = new("Romans", "Reading", "The Very Exciting Adventures of Huckleberry Karimazov");

        Console.WriteLine(basic.GetSummary());
        Console.WriteLine(mathful.GetHomeworkList());
        Console.WriteLine(writ.GetWritingInformation());
    }
}