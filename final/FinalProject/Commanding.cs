class Commanding
{
    Dictionary<string, Delegate> functional;
    WordReference dict;
    World worldly;

    public Commanding(WordReference dic, World worldd)
    {
        dict = dic;
        worldly = worldd;
        functional.Add("go", ChangeArea);
    }

    public void Go(string[] input) //all functions should be this way
    {
        //Check to see if any other part of the string is in the area
        foreach(GenericThing g in worldly.activeArea.thingsInArea)
        {
            foreach(string s in input)
            {
                if(g.GetName() == s)
                {
                    ChangeArea(g.AreaNum());
                    return;
                }
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
        
        //Guess object in area associated with nouns
        //Call function with associated words
        //Call function in class based on input, I don't want to use a bunch of if-else statements, use invoke
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