using System.Data;

class WordReference //cant call it dictionary because that already exists
{
    private Dictionary<string, string[]> words = new(); //words[0] is the most basic synonym, words[1] is the type of word (noun, verb, etc)

    public WordReference()
    {
        //add default values to dictionary
        words.Add("!!!1337!!!-x-x-x-***CODING***", new string[2] {"unknown", "unknown"}); //this is so I can have an unknown word that is unlikely to be accidently triggered
        words.Add("move", new string[2] {"go", "action"});
        words.Add("enter", new string[2] {"go", "action"});
        words.Add("go", new string[2] {"go", "action"});
        words.Add("travel", new string[2] {"go", "action"});
        words.Add("quit", new string[2] {"quit", "action"});
        words.Add("retire", new string[2] {"quit", "action"});
        words.Add("look", new string[2] {"look", "action"});
        words.Add("the", new string[2] {"the", "MUDA"}); //useless
        words.Add("uh", new string[2] {"uh", "MUDA"});
        words.Add("a", new string[2] {"a", "MUDA"});
        words.Add("at", new string[2] {"at", "MUDA"});
        words.Add("to", new string[2] {"to", "MUDA"});
        words.Add("use", new string[2] {"use", "action"});
        words.Add("activate", new string[2] {"use", "action"});
        words.Add("employ", new string[2] {"use", "action"});
        words.Add("operate", new string[2] {"use", "action"});
        words.Add("north", new string[2] {"north", "place"}); //These are definitions of places and directions
        words.Add("east", new string[2] {"east", "place"});
        words.Add("south", new string[2] {"south", "place"});
        words.Add("west", new string[2] {"west", "place"});
        words.Add("towards", new string[2] {"preposition", "MUDA"}); //prepositions aren't actually helpful for understanding people
        words.Add("talk", new string[2] {"talk", "action"});
        words.Add("communicate", new string[2] {"talk", "action"});
        words.Add("converse", new string[2] {"talk", "action"});
        words.Add("speak", new string[2] {"talk", "action"});
        words.Add("bob", new string[2] {"bob", "name"});
    }

    public WordReference(string[] words, string[][] meanings) //better have same length of arrays
    {
        //Add values entered to dictionary
        for(int x = 0; x < words.Length; x++)
        {
            this.words.Add(words[x], meanings[x]);
        }
    }

    public string[] Meaning(string x) //we love x, don't we
    {
        string[] y = {"",""};
        if(words.TryGetValue(x, out y))
        {
            return y;
        }
        else
        {
            //try guessing
            return words[FindClosest(x)];
        }
    }

    private string FindClosest(string word)
    {
        string closest = "";
        int closeness = 0;
        int temp = 0; //takes more memory, saves processing time
        List<string> possibleWords = new List<string>(words.Keys);
        foreach(string w in possibleWords)
        {
            temp = CheckSimilarity(word, w);
            if(temp > closeness)
            {
                closest = w;
                closeness = temp;
            }
        }
        if(closeness > 30) //how close do you want the word to be to use it?
        {
            Console.WriteLine("I thought that " + closest + " was the closest word in the dictionary."); //I am leaving this in because it is nice to see what the code is doing
            return closest;
        }
        else return "!!!1337!!!-x-x-x-***CODING***"; //Something unlikely to be similar to use input
    }

    private int CheckSimilarity(string a, string b) //This thing is not that good, fix weights
    {
        int x = 50; //50 is highest score, each test removes points if not exact match

        //remove difference of length
        int al = a.Length;
        int bl = b.Length;
        x -= (al > bl)?(al-bl-1):(bl-al-1) * 10; //So the problem with this algorithm is that shorter words automatically get less penalty

        //remove number of characters that are different between strings
        if(al < bl)
        {
            foreach(char character in a)
            {
                foreach(char bhar in b)
                {
                    if(!(character == bhar))
                    {
                        x--;
                    }
                }
            }
        }
        else
        {
            foreach(char character in b) //just swaps a and b
            {
                foreach(char bhar in a)
                {
                    if(!(character == bhar))
                    {
                        x--;
                    }
                }
            }
        }

        //check first and last character
        if(a[..] != b[..])
        {
            x -= 8;
        }
        if(a.Last() != b.Last())
        {
            x -= 4;
        }

        return x;
    }
}