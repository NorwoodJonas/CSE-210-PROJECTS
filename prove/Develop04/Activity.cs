abstract class Activity //because there will no no Activity object, ever
{
    protected string introM;
    protected string outroM;
    protected int time = 30; //could be float
    public Activity(string introM, string outroM)
    {
        this.introM = introM;
        this.outroM = outroM;
    }

    public abstract void StartActivity();

    public void GetTime()
    {
        Console.WriteLine("How many seconds do you want to do this for?");
        time = int.Parse(Console.ReadLine()); //I really don't care if somebody tries to enter a 0 or a negative number
    }
}