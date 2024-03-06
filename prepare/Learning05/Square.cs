class Square : Rectangle //I know
{
    public Square(string color, float side) : base (color, side, side) {} //Nothing new

    public override float GetArea()
    {
        return base.GetArea();
    }
}
