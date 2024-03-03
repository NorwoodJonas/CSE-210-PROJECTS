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

    public async void GetInput()
    {
        while(true)
        {
            Console.Write(">");
            Console.ReadLine();
        }
    }

    public async void ForceList() //imagine using threads just for this thing
    {
        Task task1 = Task.Delay(1000 * time);
        Task task2 = Task.Delay(1000); //GetInput();
        await Task.WhenAny(task1, task2);
    }

    public override void StartActivity()
    {
        Console.WriteLine(introM);

        GetTime();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Here is a random countdown timer:");
        AAnimation.Countdown(5);
        ForceList();

        Console.WriteLine(outroM);
    }
}