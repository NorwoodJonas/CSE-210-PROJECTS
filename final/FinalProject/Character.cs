class Character : GenericThing //Why is a character a GenericThing? So that I can keep all of them in the same array ofCourse().
{
    public string introMessage = "";

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

    public void setIntroMessage(string message)
    {
        introMessage = message;
    }

    public override void WhatsUp()
    {
        Console.WriteLine(introMessage);
        //Make interactive if you want, I guess it would be important if this was going to be more
    }

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