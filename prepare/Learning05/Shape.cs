abstract class Shape
{
    protected string color; //should this be colour?

    public Shape(string color)
    {
        this.color = color;
    }

    public Shape()
    {
        color = "";
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public abstract float GetArea();
}