int.TryParse(Console.ReadLine(), out var length);

var sonlar = Console.ReadLine()?
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray() ?? [];

if(length != sonlar.Length)
    throw new Exception();

var average = sonlar.Average();
foreach(var i in sonlar)
    if(i >= average)
        Console.Write($"{i} ");