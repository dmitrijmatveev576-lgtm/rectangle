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
        //Створюємо масив із 5 об'єктів класу Rectangle
        Rectangle[] rectangles = new Rectangle[]
        {
            new Rectangle(4.0, 5.0),
            new Rectangle(10.5, 2.0),
            new Rectangle(3.2, 8.1),
            new Rectangle(6.0, 6.0),
            new Rectangle(7.5, 4.2)
        };

        // Виводимо інформацію про всі прямокутники
        for (int i = 0; i < rectangles.Length; i++)
        {
            Console.WriteLine($"Прямокутник {i + 1}:");
            Console.WriteLine($"  Ширина: {rectangles[i].Width}");
            Console.WriteLine($"  Висота: {rectangles[i].Height}");
            Console.WriteLine($"  Площа: {rectangles[i].GetArea()}");
            Console.WriteLine($"  Периметр: {rectangles[i].GetPerimeter()}");
            Console.WriteLine(new string('-', 25));
        }

        //Пошук прямокутника з найбільшою площею
        Rectangle maxAreaRectangle = rectangles[0]; 
        int maxIndex = 0;

        for (int i = 1; i < rectangles.Length; i++)
        {
            if (rectangles[i].GetArea() > maxAreaRectangle.GetArea())
            {
                maxAreaRectangle = rectangles[i];
                maxIndex = i;
            }
        }

        Console.WriteLine("\n=== Прямокутник з найбільшою площею ===");
        Console.WriteLine($"Номер у масиві: {maxIndex + 1}");
        Console.WriteLine($"Ширина: {maxAreaRectangle.Width}");
        Console.WriteLine($"Висота: {maxAreaRectangle.Height}");
        Console.WriteLine($"Максимальна площа: {maxAreaRectangle.GetArea()}");
    }
}
