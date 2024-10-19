namespace Offline.Bootcamp.Day3;

public readonly struct Planet(Point center, int radius)
{
    public Point Center { get; init; } = center;
    public int Radius { get; init; } = radius;

    public Planet(string? parts) : this(new(), 0)
    {
        var parsedParts = parts?.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray() ?? [];

        Center = new Point(parsedParts[0], parsedParts[1]);
        Radius = parsedParts[2];
    }

    public bool Contains(Point point)
    {
        var a = Center.X - point.X;
        var b = Center.Y - point.Y;

        var cSquared = a * a + b * b;
        var c = Math.Sqrt(cSquared);

        return c <= Radius;
    }
}