var rectangle = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle.Width);
Console.WriteLine("Height is " + rectangle.Height);
Console.WriteLine("Area is " + rectangle.CalculateArea());
Console.WriteLine("Circumference is " + rectangle.CalculateCircumference());

Console.ReadKey();

class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
    
    public int CalculateCircumference()
    {
        return 2 * (Width + Height);
    }
}
