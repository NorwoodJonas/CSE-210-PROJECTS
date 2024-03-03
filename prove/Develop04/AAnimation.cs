class AAnimation
{
    public static void Spin(int time) //Now using lazy coding practices
    {
        Console.Write("-");
        for(int x = time * 100; time > 0; time--)
        {
            ClearChars(1);
            Console.Write("\\");
            Thread.Sleep(25);
            ClearChars(1);
            Console.Write("|");
            Thread.Sleep(25);
            ClearChars(1);
            Console.Write("/");
            Thread.Sleep(25);
            ClearChars(1);
            Console.Write("-");
            Thread.Sleep(25);
        }
    }

    public static void AnimateFrames(List<string> frames, int sleepTime)
    {
        foreach(string frame in frames)
        {
            Console.WriteLine(frame);
            Thread.Sleep(sleepTime);
            Console.Clear();
        }
    }

    public static void AnimatePart(List<string> frames, int sleepTime)
    {
        foreach(string frame in frames)
        {
            Console.WriteLine(frame);
            Thread.Sleep(sleepTime);
            ClearChars(frame.Length);
        }
    }

    public static void ClearChars(int x)
    {
        for(int y = x; y > 0; y--)
        {
            Console.Write("\b");
        }
        for(int y = x; y > 0; y--)
        {
            Console.Write(" ");
        }
        for(int y = x; y > 0; y--)
        {
            Console.Write("\b");
        }
    }

    public static void Countdown(int seconds)
    {
        System.Collections.Queue countdown = new System.Collections.Queue();
        for(int x = seconds; x > 0; x--)
        {
            countdown.Enqueue(x);
        }
        for(int x = seconds; x > 0; x--)
        {
            Console.Write(countdown.Dequeue());
            Thread.Sleep(1000);
            ClearChars(1);
        }
    }
}