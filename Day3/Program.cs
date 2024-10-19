using Offline.Bootcamp.Day3;

int.TryParse(Console.ReadLine(), out var testCases);

while (testCases-- > 0)
{
    var addressParts = Console.ReadLine()?
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray() ?? [];

    var prince = new Point(addressParts[0], addressParts[1]);
    var princess = new Point(addressParts[2], addressParts[3]);

    int.TryParse(Console.ReadLine(), out var planetCount);

    var crossings = 0;
    while (planetCount-- > 0)
    {
        var planet = new Planet(Console.ReadLine());

        var princeInside = planet.Contains(prince);
        var princessInside = planet.Contains(princess);
        var crosses = princeInside ^ princessInside;

        crossings += crosses ? 1 : 0;
    }

    Console.WriteLine(crossings);
}