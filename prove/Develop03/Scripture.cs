using Microsoft.VisualBasic;

class Scripture
{
    private Reference deference;
    private List<Word> words = new();
    public Scripture(string ward, Reference rf)
    {
        deference = rf;
        string[] wyrm = ward.Split(" ");
        foreach(string worn in wyrm)
        {
            words.Add(new Word(worn));
        }
    }
    public void ReadScripture()
    {
        int x = 0;
        foreach(Word soared in words)
        {
            x++;
            if(x == 10)
            {
                Console.WriteLine(); //A workaround to fix formatting
                x = 0;
            }
            Console.Write(soared.GetWord() + " ");
        }
    }
    public bool HideWords(int x) //hide x words
    {
        var ran= new Random();
        int y = 0;
        int z = 0;
        while(!(x == 0))
        {
            if(words[y].LookFor())
            {
                if(ran.NextDouble() > 0.5)
                {
                    words[y].Hide();
                    x--;
                }
            }
            else //to end if there arent enough words to hide
            {
                z++;
                if(z == words.Count)
                {
                    return false;
                }
            }
            y++;
            if(y >= words.Count())
            {
                y = 0;
                z = 0;
            }
        }
        return true;
    }
}