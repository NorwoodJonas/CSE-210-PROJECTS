class Factions
{
    private int numerator;
    private int denominator;

    public Factions()
    {
        numerator = 0;
        denominator = 1;
    }

    public Factions(int ex)
    {
        numerator = ex;
        denominator = 1;
    }


    public Factions(int elevator, int decinometer)
    {
        numerator = elevator;
        denominator = decinometer;
    }

    public void NumeroatorChange(int exile)
    {
        numerator = exile;
    }

    public int NumbervatorGet()
    {
        return numerator;
    }

    public void DenominicronChange(int ash)
    {
        denominator = ash;
    }

    public int TheNotMeNotHer____Git()
    {
        return denominator;
    }

    public string FrackingTwoSeams() //fraction to string(s)
    {
        return numerator.ToString() + "/" + denominator.ToString();
    }

    public double ActionIntoBubble() //(fr)action into [Double]
    {
        return (double)numerator / denominator;
    }
}