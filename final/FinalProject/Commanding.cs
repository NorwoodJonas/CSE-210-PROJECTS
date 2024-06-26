using System.Diagnostics.Contracts;

class Commanding
{
    Dictionary<string, Cultist> functional = new();
    WordReference dict;
    World worldly;
    Dictionary<string, string[]> neededThings = new();

    private delegate void Cultist(List<string> imps); //I need to make all of these functions take List<string>

    public Commanding()
    {
        dict = new WordReference();
        worldly = new World();
    }

    public Commanding(WordReference dic, World worldd)
    {
        dict = dic;
        worldly = worldd;
        functional.Add("go", Go); //go is a poorly implemented function tbh, Maybe I will change it, probably not
        string[] t = {"place"}; //Because it allows you to go anywhere, but you want to limit the person to access from portals in the area
        neededThings.Add("go", t); //I wish c# would let me use curly brackets to define string arrays anywhere
        functional.Add("look", Look);
        string[] poorPractice = {};
        neededThings.Add("look", poorPractice);
        functional.Add("use", Look);
        string[] ahhhh = {"object"};
        neededThings.Add("use", ahhhh); //seriously, how do I do this better
        functional.Add("talk", Talk);
        neededThings.Add("talk", poorPractice); //seriously, how do I do this better
        //Add examine/inspect
    }

    public void Go(List<string> input) //all functions should be this way
    {
        if(!input.Any())
        { //error checking
            return;
        }
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

    public bool Do(string[] input)
    {
        //Get a string[] of wordtypes and string[] of meanings
        List<string> wordType = new(); //I prefer using lists, okay
        List<string> meaning = new(); //may need to change from input to meaning in this code
        string[] whyDoINeedThis = {"",""}; //I don't, I figure it will save processing at the cost of memory

        foreach(string s in input)
        {
            whyDoINeedThis = dict.Meaning(s);
            meaning.Add(whyDoINeedThis[0]);
            wordType.Add(whyDoINeedThis[1]);
        }

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
        if(actionNum == -1) //In case nothing was found
        {
            Console.WriteLine("You make no sense.");
            return true;
        }
        if(meaning[actionNum] == "quit") //allows program to exit if user wants to quit
        {
            return false;
        }
        //Try finding other words associated with that action
        string[] wordsToFind = neededThings[meaning[actionNum]];
        List<string> arguably = new();
        foreach(string s in wordsToFind)
        {
            temp = 0;
            foreach(string b in wordType)
            {
                if(s == wordType[temp])
                {
                    arguably.Add(meaning[temp]);
                }
                temp++;
            }
        }
        //I was going to overload the method but delegates don't like method groups so... IDK
        //I need a list of word types I need with each command. Done.
        //Guess object in area associated with nouns, only if you need nouns though
        //Call function with associated words
        Cultist worthy = functional[meaning[actionNum]]; //How to properly invoke these delegates? Getting closer. //I changed this from input to meaning, that was wrong, now it is correct
        worthy(arguably); //Okay, so, apparently I can use a non-generic delegate, which while I like using generic things it is better not to. SMH
        return true;
    }
    //Make all of the commands that affect things here, things like items, spells, characters, and such will call commands here

    public void Place() //have all commands have chance of happening
    {
        //Puts item in area
        worldly.activeArea.PlaceThing(new GenericThing(this)); //This isn't what it should be
    }

    public void Talk(List<string> brosName)
    {
        if(!brosName.Any()) //could add to findFromName
        { //error checking
            return;
        }
        GenericThing bro = FindFromName(brosName[0]);
        bro.WhatsUp();
    }

    public GenericThing FindFromName(string name) //I should have done this sooner
    {
        GenericThing g = new(this);
        foreach(GenericThing trinket in worldly.activeArea.thingsInArea)
        {
            if(trinket.GetName() == name) //could make it so you can list all you want to take
            {
                g = trinket;
            }
        }
        return g; //Oh no, it will return an empty object if nothing is found. SMH.
    }

    public void Take(List<string> theft)
    {
        //Take item from active area
        //Find item in area
        GenericThing g = new(this); //fix this
        foreach(GenericThing trinket in worldly.activeArea.thingsInArea)
        {
            if(trinket.GetName() == theft[0]) //could make it so you can list all you want to take
            {
                g = trinket;
            }
        }
        worldly.pc.Give(g);
    }

    public void PassTime(int x)
    {
        worldly.SetTime(x, true);
    }

    public static void Damage(GenericThing g)
    {

    }

    public static void Heal(GenericThing h) //For these things, give the name of the genericthing/things in a list, then have the function find them themselves
    {
        
    }
    
    public void Look(List<string> input)
    {
        Console.WriteLine(worldly.activeArea.DescribeArea());
    }

    public void ChangeArea(int x)
    {
        worldly.SetActive(x);
        worldly.activeArea.DescribeArea(); //I would make a function, but it would feel a little silly as that function would just call the active area function so, you know
    }

    public void Use(List<string> input)
    {

    }
}