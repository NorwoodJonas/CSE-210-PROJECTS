using Microsoft.VisualBasic;

class FoolishDesign
{
    private readonly string[] sigh = {"One", "Two", "Three", "Four", "Five"};
    public string Prompt()
    {
        var rand = new Random(); //wow, declaring a new random each time...
        return sigh[rand.Next(0, sigh.Length - 1)];
    }

    public string Date()
    {
        return DateTime.Now.ToString();
    }
}