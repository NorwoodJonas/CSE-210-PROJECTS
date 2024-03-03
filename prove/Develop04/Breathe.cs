class Breathe : Activity
{
    private int breathIn = 5;
    private int breathOut = 5;

    public Breathe(string introM, string outroM): base(introM, outroM)
    {
    }

    public override void StartActivity()
    {
        Console.WriteLine(introM);
        GetTime();
        Breath();
        Console.WriteLine(outroM);
    }

    private void Breath()
    {
        int cycles = time / (breathIn + breathOut); //Anything less will get 0 cycles, you could add 1 to round up
        while(cycles > 0)
        {
            Console.Write("\nBreathe in: ");
            AAnimation.Countdown(breathIn);
            Console.Write("\nBreathe out: ");
            AAnimation.Countdown(breathOut);
            cycles--;
        }
        Console.WriteLine();
    }
}