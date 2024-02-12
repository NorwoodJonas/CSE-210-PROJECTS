class Word
{
    private string word;
    private string blank;
    private bool show = true;
    public Word(string word)
    {
        string temp = "";
        this.word = word;
        for(int x = word.Length; x >= 0; x--)
        {
            temp += "_"; //concatanate, hopefully
        }
        blank = temp;
    }
    public string GetWord()
    {
        if(show) return word;
        else return blank;
    }
    public void Hide()
    {
        show = false;
    }
    public void Reveal()
    {
        show = true;
    }
    public bool LookFor()
    {
        return show;
    }
}