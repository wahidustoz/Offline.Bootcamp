namespace Offline.Bootcamp.Day2;

public struct Coordinate(double latitude, double longitude)
{
    private double latitude = latitude;
    public double Latitude
    {
        get { return this.latitude; }
        init 
        {
            if (value < 0)
                throw new Exception("Latitude should be > 0.");
            else 
                this.latitude = value;
        }
    }
    public double Longitude { get; init; } = longitude;

    public Coordinate(string? coordinate) : this(0, 0)
    {
        var parts = coordinate?
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray() ?? [];

        (Latitude, Longitude) = (parts[0], parts[1]);
    }

    public double DistanceTo(Coordinate boshqa)
    {
        const double R = 6371000;

        double dLat = ToRadians(boshqa.Latitude - Latitude);
        double dLon = ToRadians(boshqa.Longitude - Longitude);

        
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(ToRadians(Latitude)) * Math.Cos(ToRadians(boshqa.Latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c; 
    }

    private double ToRadians(double angle) => angle * Math.PI / 180.0;
}