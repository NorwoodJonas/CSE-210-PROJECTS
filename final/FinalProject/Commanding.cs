using System.Diagnostics.Contracts;

class Commanding
{
    Dictionary<string, Delegate> functional;
    WordReference dict;
    World worldly;
    Dictionary<string, string[]> neededThings;

    private delegate string[] Why(bool x);

    public Commanding(WordReference dic, World worldd)
    {
        dict = dic;
        worldly = worldd;
        functional.Add("go", Go);
        string[] t = {"place"};
        neededThings.Add("go", t); //I wish c# would let me use curly brackets to define string arrays anywhere
    }

    public void Go(List<string> input) //all functions should be this way
    {
        //Check to see if any other part of the string is in the area
        foreach(GenericThing g in worldly.activeArea.thingsInArea)
        {
            if(g.GetName() == input[0])
            {
                ChangeArea(g.AreaNum());
                return;
            }
        }
        Console.WriteLine($"You fail to {0} anywhere", input[0]); //you fail to go anywhere, etc. Could be done better
    }

    public void Do(string[] input, string[] wordType)
    {
        //Go look at the first action
        int actionNum = -1;
        int temp = 0; //we love our temp workers
        foreach(string s in wordType)
        {
            if(s == "action")
            {
                actionNum = temp;
            }
            temp++;
        }
        //Try finding other words associated with that action
        string[] wordsToFind = neededThings[input[actionNum]];
        List<string> arguably = new();
        foreach(string s in wordsToFind)
        {
            temp = 0;
            foreach(string b in wordType)
            {
                if(s == wordType[temp])
                {
                    arguably.Add(input[temp]);
                }
                temp++;
            }
        }
        //I was going to overload the method but delegates don't like method groups so... IDK
        //I need a list of word types I need with each command. Done.
        //Guess object in area associated with nouns, only if you need nouns though
        //Call function with associated words
        functional[input[actionNum]](arguably); //How to properly invoke these delegates?
    }
    //Make all of the commands that affect things here, things like items, spells, characters, and such will call commands here

    public static void Place() //have all commands have chance of happening
    {
        //Puts item in area
    }

    public void PassTime(int x)
    {
        worldly.SetTime(x, true);
    }

    public static void Damage(GenericThing g)
    {

    }

    public static void Heal(GenericThing h)
    {
        
    }

    public void ChangeArea(int x)
    {
        worldly.SetActive(x);
        worldly.activeArea.DescribeArea(); //I would make a function, but it would feel a little silly as that function would just call the active area function so, you know
    }
}