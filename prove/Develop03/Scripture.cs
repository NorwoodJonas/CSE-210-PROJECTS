using Microsoft.VisualBasic;

class Scripture
{
    private Reference deference;
    private List<Word> words;
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
        foreach(Word soared in words)
        {
            Console.Write(soared.GetWord());
        }
    }
    public void HideWords(int x) //hide x words
    {
        var ran= new Random();
        int y = 0;
        int z = 0;
        while(!(x == 0 && z == words.Count))
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
            }
            y++;
        }
    }
}