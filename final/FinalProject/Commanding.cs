class Commanding
{
    Dictionary<string, Delegate> functional;
    WordReference dict = new();

    public static void Do(string[] input)
    {
        
        //Call function in class based on input, I don't want to use a bunch of if-else statements, use invoke
    }
    //Make all of the commands that affect things here, things like items, spells, characters, and such will call commands here
}