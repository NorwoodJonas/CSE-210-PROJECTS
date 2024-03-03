class Reflect : Activity
{
    private string[] prompts = {"Think of a time where you did something cool.", "Think of when you acted like Jesus.", "Think of a time when you helped someone.", "Think about that time you did something you regret.", "Think of when you overcame the world."};
    private string[] questions = {"How did this make you feel?",
    "How did you feel when this was over?",
    "What did you learn about yourself?",
    "What could you teach others about this experience?",
    "How did you start?",
    "How did you end up in this situation?"};
    public Reflect(string intro, string outro): base(intro, outro)
    {
    }

    public string GetRandomPrompt()
    {
        var ran = new Random();

        return prompts[ran.Next(prompts.Length)];
    }

    public string GetRandomQuestion()
    {
        var ran = new Random();

        return questions[ran.Next(questions.Length)];
    }

    public override void StartActivity()
    {
        Console.WriteLine(introM);

        GetTime();

        Console.WriteLine(GetRandomPrompt());

        int cycles = time / 10; //Anything less will get 0 cycles, you could add 1 to round up
        while(cycles > 0)
        {
            Console.Write(GetRandomQuestion());
            Console.WriteLine();
            AAnimation.Spin(10);
            cycles--;
        }

        Console.WriteLine(outroM);
    }
}