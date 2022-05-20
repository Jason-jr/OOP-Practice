namespace OOP;

public class Circle : Shape
{
    public Circle(int width, int height) : base(width, height) { }

    public override void CalcArea() => _area = Math.Pow(Width, 2) * Math.PI;
}