class Character : GenericThing //Why is a character a GenericThing? So that I can keep all of them in the same array ofCourse().
{
    public Character(Commanding c) : base(c)
    {

    }

    public void NewPlayerCharacter()
    {
        var rand = new Random();
        Console.Write("CharacterName: ");
        name = Console.ReadLine();
        Console.WriteLine("\nI would ask you for stats, but I really don't care. You get these: ");
        health = rand.Next(5, 15);
        strength = rand.Next(5,10);
        Console.WriteLine($"Strength: {strength} Health: {health}");
    }

    public Character() : base()
    {}

    public void ChangeStrength()
    {

    }

    public void ChangeWeight()
    {

    }

    public void ChangeHeight()
    {

    }
}