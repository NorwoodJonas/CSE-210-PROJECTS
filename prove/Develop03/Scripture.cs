using Microsoft.VisualBasic;

class Scripture
{
    private LinkedList<Word> words;
    public Scripture(Word[] ward)
    {
        foreach(Word w in ward)
        {
            words.AddLast(w);
        }
    }
}