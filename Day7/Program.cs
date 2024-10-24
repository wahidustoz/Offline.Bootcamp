// using Offline.Bootcamp.Day7;

// var toqSet = new HashSet<int> ([1,3,5,7,9]);
// var juftSet = new HashSet<int> ([2,4,6,8,10]);

// toqSet.UnionWith(juftSet);
// toqSet.ToList().ForEach(Console.WriteLine);


// toqSet.UnionBy(juftSet, x => x).ToList().ForEach(Console.WriteLine);
// toqSet.Union(juftSet).ToList().ForEach(Console.WriteLine);

// var a = new List<int>([ 1, 2, 3]);
// var b = new List<int>([ 1, 2, 3]);
// var c = a;

// Console.WriteLine(a.Equals(b));
// Console.WriteLine(a.Equals(c));

// var son1 = 1;
// var son2 = 1;

// Console.WriteLine(son1 == son2);
// Console.WriteLine(son1.Equals(son2));

// var nuqtaA = new Point(1, 1);
// var nuqtaB = new Point(1, 1);

// Console.WriteLine(nuqtaA.Equals(nuqtaB));
// Console.WriteLine(nuqtaA);
// Console.WriteLine(nuqtaB);

// Console.WriteLine(nuqtaA.GetHashCode());
// Console.WriteLine(nuqtaB.GetHashCode());

// var son1 = new List<int>();
// var son2 = new List<int>();
// Console.WriteLine(son1.GetHashCode());
// Console.WriteLine(son2.GetHashCode());


// using System.Diagnostics.CodeAnalysis;
// using Offline.Bootcamp.Day7;

// var lugat = new Dictionary<Point, int>(new PointComparer())
// {
//      { new Point(0,0), 3 },
//      { new Point(1,1), 2 },
//      { new Point(1,0), 5 },
// };

// foreach(var key in lugat.Keys)
//     Console.WriteLine(key);

// Console.WriteLine(lugat.ContainsKey(new Point(0, 0)));


// public class PointComparer : IEqualityComparer<Point>
// {
//     public bool Equals(Point? x, Point? y)
//         => x!.Equals(y);

//     public int GetHashCode([DisallowNull] Point obj)
//         => HashCode.Combine(obj.X, obj.Y);
// }

// using Offline.Bootcamp.Day7;

// var eshmat = new Student { Id = 1233232, Name = "Eshmat", Grade = 2.3 };
// var toshmat = new Student { Id = 1233232, Name = "Toshmat", Grade = 5.4 };

// Console.WriteLine(eshmat.Equals(toshmat)); // true
// Console.WriteLine(eshmat.GetHashCode()); // x -> idga bog'liq
// Console.WriteLine(toshmat.GetHashCode()); // x -> idga bog'liq

// var bugun = Enum.Parse<Weekday>(Console.ReadLine() ?? "", true);
// Console.WriteLine(bugun);
// var kun = Weekday.Friday;

// Console.WriteLine((int)kun);

var son = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(son is >= 15 and <= 100);

object sonlar1 = new List<int>([1, 2, 3]);
object sonlar2 = new int[] { 1, 2, 3 };

if(sonlar1.GetType() == typeof(List<int>))
{
    var y = (List<int>)sonlar1;
    y.Add(1);
}

if(sonlar1 is List<int> x)
    Console.WriteLine("Bu list, vsyo");
else if (sonlar2 is int[] arraySonlar)
    arraySonlar[0] = 3;



public enum Weekday
{
    Monday = 1,
    Tuesday,
    Wednesday = 100,
    Thursday,
    Friday,
    Saturday, 
    Sunday
}

public enum Currency
{
    USD,
    UZS,
    RUB,
    ETH = 100,
    BTC,
    BNB,
    USDT
}