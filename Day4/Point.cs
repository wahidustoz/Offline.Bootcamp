namespace Offline.Bootcamp.Day4;

// Offline.Bootcamp.Day4.Point - fully qualified name
public readonly struct Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;

    public override string ToString() => $"({X}, {Y})";
}