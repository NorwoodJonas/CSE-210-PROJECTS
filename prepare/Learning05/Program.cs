using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        shapes.Add(new Rectangle("Red",10,5));
        shapes.Add(new Square("Blue",5));
        shapes.Add(new Circle("Green",3));

        foreach(Shape s in shapes)
        {
            Console.WriteLine($"{s.GetColor()} : {s.GetArea()}");
        }

        shapes[0].SetColor("Purple");
        Console.WriteLine(shapes[0].GetColor());
    }
}