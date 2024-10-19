namespace Offline.Bootcamp.Day1;

public struct Coordinate(double latitude, double longitude)
{   
    const double EarthRadius = 6371000;

    public double Latitude { get; init; } = latitude;
    public double Longitude { get;  init; } = longitude;

    public Coordinate(string? coordinate) : this(0, 0)
    {
        var parts = coordinate?
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).ToArray();

        if (parts is { Length: 2 })
            (Latitude, Longitude) = (parts[0], parts[1]);
    }

    public double DistanceTo(Coordinate other)
    {
        double dLat = ToRadians(other.Latitude - Latitude);
        double dLon = ToRadians(other.Longitude - Longitude);

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(ToRadians(Latitude)) * Math.Cos(ToRadians(other.Latitude)) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return EarthRadius * c;
    }

    private double ToRadians(double degrees) => degrees * (Math.PI / 180);

    public static Coordinate From(string? coordinate)  => new(coordinate);
}