class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle() { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetRectangleArea()); // 50

        Square square = new Square() { Side = 5 };
        Console.WriteLine(square.GetArea()); // 25

        Console.ReadKey();
    }
}
