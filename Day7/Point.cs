namespace Offline.Bootcamp.Day7;

public class Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;


    public override string ToString() => $"[{X}, {Y}]";
    public override bool Equals(object? obj)
        => obj is Point p && p.X  == X && p.Y == Y;
}