class Reference
{
    private string book;
    private int[] verses = new int[2];
    public Reference(string book, int verse) //why make a class when you can literally just use a string, it is more effort without benefit
    {
        this.book = book;
        verses[0] = verse;
        verses[1] = verse;
    }
    public Reference(string book, int versace, int versEnd)
    {
        this.book = book;
        verses[0] = versace;
        verses[1] = versEnd;
    }
}