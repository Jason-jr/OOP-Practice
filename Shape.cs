namespace OOP;

public abstract class Shape
{
    private protected double _area;

    public int Width { get; init; }

    public int Height { get; init; }

    public Shape(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public abstract void CalcArea();

    public double GetArea()
    {
        return _area;
    }

    public void PrintArea()
    {
        Console.WriteLine(_area);
    }
}