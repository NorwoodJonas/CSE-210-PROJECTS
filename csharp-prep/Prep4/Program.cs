using System;

class Program
{
    static void Main(string[] args)
    {
        int aVariableBecauseOfSimplicityEvenThoughItIsNotVeryUseful = -1; //poorly named variable, makes code hard to read, why use it?
        Console.WriteLine("---ListMaker v21.7.0---");
        List<int> numeros = new List<int>();
        Console.WriteLine("Enter some numbers, type 0 when you are done");
        while(aVariableBecauseOfSimplicityEvenThoughItIsNotVeryUseful != 0)
        {
            Console.Write("Number: ");
            aVariableBecauseOfSimplicityEvenThoughItIsNotVeryUseful =int.Parse(Console.ReadLine());
            if(aVariableBecauseOfSimplicityEvenThoughItIsNotVeryUseful != 0)
                numeros.Add(aVariableBecauseOfSimplicityEvenThoughItIsNotVeryUseful); //don't need curly braces, take that standard coding practices.
        }
        int total = 0;
        foreach(int numbero in numeros) total += numbero; //At least this is compact
        float average = total / numeros.Count;
        Console.WriteLine($"The sum is {total}"); //got my "The sum is {total}" dollar bills
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {numeros.Max()}");
    }
}