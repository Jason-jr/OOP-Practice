namespace OOP;

public class Square : Shape
{
    public Square(int width, int height) : base(width, height) { }

    public override void CalcArea() => _area = Width * Height;
}