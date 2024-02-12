using Microsoft.VisualBasic;

class Scripture
{
    private Reference deference;
    private LinkedList<Word> words;
    public Scripture(string ward, Reference rf)
    {
        deference = rf;
        string[] wyrm = ward.Split(" ");
        foreach(string worn in wyrm)
        {
            words.AddLast(new Word(worn));
        }
    }
    public void readScripture()
    {
        foreach(Word soared in words)
        {
            Console.Write(soared.getWord());
        }
    }
}