namespace OOP;

public class Triangle : Shape
{
    public Triangle(int width, int height) : base(width, height) { }

    public override void CalcArea() => _area = Width * Height / 2;
}