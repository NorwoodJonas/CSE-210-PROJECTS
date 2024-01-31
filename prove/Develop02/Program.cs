using System;

class Program
{
    static void Main(string[] args)
    {
        Journal ofCourse = new Journal();
        Menu whatever = new Menu("Journal Program 1.29.86", ofCourse);
        do
        {
            whatever.ShowMenu();
        }
        while(whatever.Option()); //In theory it should run Option every time
        return;
    }
}