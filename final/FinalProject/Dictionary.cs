class WordReference //cant call it dictionary because that already exists
{
    private Dictionary<string, string[]> words; //words[0] is the most basic synonym, words[1] is the type of word (noun, verb, etc)

    public WordReference()
    {
        //add default values to dictionary
    }

    public WordReference(string[] words, string[][] meanings) //better have same length of arrays
    {
        //Add values entered to dictionary
        for(int x = 0; x < words.Length; x++)
        {
            this.words.Add(words[x], meanings[x]);
        }
    }

    public string Meaning(string[] x) //we love x, don't we
    {
        string[] y = {"",""};
        if(words.TryGetValue(x, out y))
        {
            return y;
        }
        else
        {
            //try guessing

        }
    }

    private int CheckSimilarity(string a, string b)
    {
        int x = 0;
        List<string> possibleWords = new List<string>(words.Keys);
    }
}