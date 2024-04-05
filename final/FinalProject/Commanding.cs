class Commanding
{
    Dictionary<string, Delegate> functional;
    WordReference dict;
    World worldly;

    public Commanding(WordReference dic, World worldd)
    {
        dict = dic;
        worldly = worldd;
    }

    public static void Do(string[] input)
    {
        
        //Call function in class based on input, I don't want to use a bunch of if-else statements, use invoke
    }
    //Make all of the commands that affect things here, things like items, spells, characters, and such will call commands here

    public static void Place() //have all commands have chance of happening
    {
        //Puts item in area
    }

    public static void PassTime(int x)
    {
        time += x;
    }

    public static void Damage(GenericThing g)
    {

    }

    public static void Heal(GenericThing h)
    {
        
    }
}