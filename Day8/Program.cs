// using Offline.Bootcamp.Day8;

// var meetingDay = Weekdays.Monday;
// var damOlishKunlar = new Weekdays[] { Weekdays.Saturday, Weekdays.Sunday };

// var weekend = Weekdays.Saturday | Weekdays.Sunday;

// Console.WriteLine(weekend);

// Console.ReadLine()?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries | StringSplitOptions.None);

// using Offline.Bootcamp.Day8;

// var point = Point.From("10,20");
// var point2 = new Point(10, 2);

// Point.Name = "Point 1";

// Console.WriteLine(point);
// Console.WriteLine(point2);

// Console.WriteLine(point.DistanceTo(point2));
// Console.WriteLine(point2.DistanceTo(point));


// Sonlar nomli extension method yozing
// u stringni ',' bilan ajratib, sonlarni ikkinchi out parametrga joylasin
// va nechta son o'qilganini qaytarsin
// sonlar bu - int[]

using Offline.Bootcamp.Day8;


var count = Console.ReadLine().Sonlar(out var sonlar);
var engKattasi = sonlar.EngKattasi();
