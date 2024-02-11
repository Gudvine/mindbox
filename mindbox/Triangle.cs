namespace mindbox;

public class Triangle : IShape
{
    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }

    // Полупериметр для вычисления площадей
    private double HalfPerimeter => (Side1 + Side2 + Side3) / 2;

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            throw new ArgumentException("Неверно указана одна из сторон");

        var maxSide = Math.Max(side1, Math.Max(side2, side3));
        var perimeter = side1 + side2 + side3;

        if ((perimeter - maxSide) < maxSide)
            throw new ArgumentException("Наибольшая сторона треугольника не должна быть больше суммы других сторон");

        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double GetArea()
    {
        // Учтем вычисления площади треугольника, если он равносторонний
        if (IsEquilateral())
            return Math.Sqrt(3d) * Math.Pow(Side1, 2d) / 4;

        // Применяем формулу Герона
        return Math.Sqrt(HalfPerimeter * (HalfPerimeter - Side1) * (HalfPerimeter - Side2) * (HalfPerimeter - Side3));
    }

    /// <summary>
    /// Проверяет - является ли треугольник прямоугольным
    /// </summary>
    public bool IsRight()
    {
        if ((Math.Pow(Side1, 2d) == Math.Pow(Side2, 2d) + Math.Pow(Side3, 2d)) 
            || (Math.Pow(Side2, 2d) == Math.Pow(Side1, 2d) + Math.Pow(Side3, 2d))
            || (Math.Pow(Side3, 2d) == Math.Pow(Side2, 2d) + Math.Pow(Side1, 2d)))
            return true;

        return false;
    }

    /// <summary>
    /// Определяет, является ли треугольник равносторонним
    /// </summary>
    public bool IsEquilateral()
        => Side1 == Side2 && Side1 == Side3 ? true : false;
}
