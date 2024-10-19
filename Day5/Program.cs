// var sonlar = new List<int> { 1, 2, 3 };
// List<string> ismlar = [ "Ali", "Vali", "G'ani" ];

// List<string> yangiIsmlar1 = [ "Jasur", ..ismlar, "Eshmat", "Toshmat" ];
// List<string> yangiIsmlar2 = ismlar;

// yangiIsmlar1[0] = "Yangi 1";
// yangiIsmlar2[0] = "Yangi 2";

// // Console.WriteLine(string.Join(", ", ismlar));           
// Console.WriteLine(string.Join(", ", yangiIsmlar1));     
// Console.WriteLine(string.Join(", ", yangiIsmlar1[..2]));     
// Console.WriteLine(string.Join(", ", yangiIsmlar1[2..]));     
// Console.WriteLine(string.Join(", ", yangiIsmlar1[2..^4]));   

// // Console.WriteLine(string.Join(", ", yangiIsmlar2));


Dictionary<string, DateTime> sanalar = new()
{
    { "Mart", new DateTime(2024, 3, 1) },
    { "Yanvar", new DateTime(2024, 1, 1) },
};

sanalar.TryAdd("April", DateTime.Now.AddYears(-1));
Console.WriteLine(sanalar["Mart"]);
sanalar["Mart"] = DateTime.Now;
Console.WriteLine(sanalar["Mart"]);

foreach(var sana in sanalar)
    Console.WriteLine($"{sana.Key} {sana.Value}");

var sonlar = new List<int>();
Console.WriteLine($"{sonlar.Count} {sonlar.Capacity}");
for(int i = 0; i < 100; i ++)
{
    sonlar.Add(new Random().Next());
    Console.WriteLine($"{sonlar.Count} {sonlar.Capacity}");
}

sonlar.TrimExcess();