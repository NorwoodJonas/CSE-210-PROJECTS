using System.ComponentModel.Design;

class Reference
{
    private string book;
    private int[] verses = new int[2];
    public Reference(string book, int chapter, int verse) //why make a class when you can literally just use a string, it is more effort without benefit
    {
        this.book = book;
        verses[0] = verse;
        verses[1] = verse;
    }
    public Reference(string book, int chapter, int versace, int versEnd)
    {
        this.book = book;
        verses[0] = versace;
        verses[1] = versEnd;
    }
    public string View() //it would be better to use string.
    {
        return book + verses[0].ToString() + verses[1].ToString();
    }
}