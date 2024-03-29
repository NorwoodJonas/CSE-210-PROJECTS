using System.Data;

class WordReference //cant call it dictionary because that already exists
{
    private Dictionary<string, string[]> words; //words[0] is the most basic synonym, words[1] is the type of word (noun, verb, etc)

    public WordReference()
    {
        //add default values to dictionary
        words.Add("!!!1337!!!-x-x-x-***CODING***", new string[2] {"unknown", "unknown"}); //this is so I can have an unknown word that is unlikely to be accidently triggered
        words.Add("", new string[2] {"", ""});
        words.Add("", new string[2] {"", ""});
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
            }
        }
        if(closeness > 45) //how close do you want the word to be to use it?
            return closest;
        else return "!!!1337!!!-x-x-x-***CODING***"; //Something unlikely to be similar to use input
    }

    private int CheckSimilarity(string a, string b)
    {
        int x = 50; //50 is highest score, each test removes points if not exact match

        //remove difference of length
        int al = a.Length;
        int bl = b.Length;
        x -= (al > bl)?(al-bl-1):(bl-al-1);

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