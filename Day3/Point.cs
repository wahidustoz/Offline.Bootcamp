namespace Offline.Bootcamp.Day3;

public readonly struct Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;
}