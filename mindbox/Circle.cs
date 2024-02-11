namespace mindbox;

public class Circle : IShape
{
    /// <summary>
    /// Радиус окружности
    /// </summary>
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Неверно указан радиус", nameof(radius));

        Radius = radius;
    }

    public double GetArea()
        => Math.PI * Math.Pow(Radius, 2);
}
