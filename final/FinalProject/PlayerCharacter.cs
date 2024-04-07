class PlayerCharacter //So, this is important that a PC vs a NPC are different, PC does not need to be in the array in areas, and I need to have one when building the world.
{
    private List<GenericThing> inventory = new List<GenericThing>();

    string name = "";
    int health = 0;
    int strength = 0;

    public PlayerCharacter()
    {
        var rand = new Random();
        Console.Write("CharacterName: ");
        name = Console.ReadLine();
        Console.WriteLine("\nI would ask you for stats, but I really don't care. You get these: ");
        health = rand.Next(5, 15);
        strength = rand.Next(5,10);
        Console.WriteLine($"Strength: {strength} Health: {health}");
    }

    public void Give(GenericThing thing)
    {
        inventory.Add(thing);
    }
}