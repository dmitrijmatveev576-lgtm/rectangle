using System;

class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Конструктор класу
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Rectangle[] rectangles = new Rectangle[]
        {
            new Rectangle(5.0, 3.0),
            new Rectangle(7.5, 4.2)
        };

        for (int i = 0; i < rectangles.Length; i++)
        {
            Console.WriteLine($"Прямокутник {i + 1}:");
            Console.WriteLine($"  Ширина: {rectangles[i].Width}");
            Console.WriteLine($"  Висота: {rectangles[i].Height}");
            Console.WriteLine($"  Площа: {rectangles[i].GetArea()}");
            Console.WriteLine($"  Периметр: {rectangles[i].GetPerimeter()}");
            Console.WriteLine(new string('-', 25));
        }
    }
}
