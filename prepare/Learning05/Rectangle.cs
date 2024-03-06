class Rectangle : Shape
{
    protected float side1;
    protected float side2;

    public Rectangle(string color, float side1, float side2) : base(color)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public override float GetArea()
    {
        return side1 * side2;
    }
}
