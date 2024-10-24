namespace Offline.Bootcamp.Day8;

public class Point(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public static string? Name { get; set; } = "Point";

    public static Point From(string? input)
    {
        var parts = input?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (parts is null || parts.Length != 2)
            throw new ArgumentException("Invalid input");

        Name = $"Point yaratildi {DateTime.Now:HH:mm:ss}";

        return new Point(int.Parse(parts[0]), int.Parse(parts[1]));
    }

    public override string ToString() => $"{Name}: {X}, {Y}";
}

public static class PointExtensions
{
    public static double DistanceTo(this Point point, Point other)
    {
        return Math.Sqrt(Math.Pow(point.X - other.X, 2) + Math.Pow(point.Y - other.Y, 2));
    }


}

public static class StringExtensions
{
    public static int Sonlar(this string? input, out int[]? sonlar)
    {
        var result = new List<int>();
        input?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .ToList()
            .ForEach(x => 
            {
                if(int.TryParse(x, out var son))
                    result.Add(son);
            });
        
        sonlar = [..result];
        
        return sonlar?.Length ?? 0;
    }

    public static int EngKattasi(this int[]? sonlar)
    {
        if(sonlar is not { Length: > 0 })       // pattern-matching
            return 0;                           // short-circuiting
        
        var max = sonlar[0];

        foreach(var son in sonlar)
            if(son > max)
                max = son;

        return max;
    }
}
