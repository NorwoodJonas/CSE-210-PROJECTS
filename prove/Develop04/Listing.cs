class Listing : Activity
{
    private string[] prompts = {"Why do you exist", "How do you feel about dating?", "How are classes going?", "Does life matter to you?", "How are you doing?"};
    public Listing(string inn, string outt) : base(inn, outt)
    {
    }

    public string GetRandomPrompt()
    {
        var ran = new Random();

        return prompts[ran.Next(prompts.Length)];
    }

    public void GetInputWait()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = DateTime.Now;
        endTime = endTime.AddSeconds(time);
        while(currentTime < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }

    public override void StartActivity()
    {
        Console.WriteLine(introM);

        GetTime();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Here is a random countdown timer:");
        AAnimation.Countdown(5);
        GetInputWait();

        Console.WriteLine(outroM);
    }
}