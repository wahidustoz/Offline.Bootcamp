// text data - string
// var input = Console.ReadLine();
// var inputlar = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
// var son1 = int.Parse(inputlar[0]);
// var son2 = int.Parse(inputlar[1]);

var sum = Console.ReadLine()?
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Sum();

Console.WriteLine(sum);