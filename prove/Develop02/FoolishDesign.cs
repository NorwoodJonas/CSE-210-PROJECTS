using Microsoft.VisualBasic;

class FoolishDesign
{
    private readonly string[] sigh = {"What did you do today?", "How is life?", "How are you doing spiritually?", "How was school?", "How was work?"};
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