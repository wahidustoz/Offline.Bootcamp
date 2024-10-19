# Kichik Shahzoda va Sayyoralar Muammosi

Salom, aziz o'quvchilar! Bugun biz "Kichik Shahzoda" masalasini yechish uchun yaratilgan dastur haqida batafsil gaplashamiz. Bu masala shahzoda va malika orasidagi sayyoralarni sanash bilan bog'liq.

## Masala tavsifi

Bizning vazifamiz shahzoda va malikaning koordinatalari hamda bir nechta sayyoralar haqidagi ma'lumotlar berilganda, shahzoda va malika orasidagi yo'lda nechta sayyora chegarasini kesib o'tish kerakligini aniqlashdan iborat.

## Yechim tuzilishi

Yechimimiz uchta asosiy strukturadan iborat:

1. `Point` - nuqtani ifodalovchi struktura
2. `Planet` - sayyorani ifodalovchi struktura
3. `Program` - asosiy dastur mantiqini o'z ichiga olgan sinf

Keling, har bir strukturani batafsil ko'rib chiqaylik va muhim kod qismlarini tahlil qilaylik.

### Point struktura
```csharp
public readonly struct Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;
}
```


`Point` struktura juda sodda bo'lib, faqat X va Y koordinatalarni saqlaydi. Biz uni quyidagi sabablarga ko'ra `readonly struct` sifatida e'lon qildik:

1. **Immutability (O'zgarmaslik)**: `readonly` kalit so'zi strukturaning o'zgarmas bo'lishini ta'minlaydi. Bu xotira samaradorligini oshiradi va xatolarni kamaytiradi.
2. **Performance (Samaradorlik)**: Strukturalar stack xotirada saqlanadi, bu esa reference type'larga nisbatan tezroq ishlashga olib keladi.
3. **Initialization-only properties**: `init` kalit so'zi faqat obyekt yaratilish paytida qiymat berishga imkon beradi, keyinchalik o'zgartirib bo'lmaydi.

### Planet struktura

```csharp
public readonly struct Planet(string? parts) : this(new(), 0)
{
    var parsedParts = parts?.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray() ?? [];

    Center = new Point(parsedParts[0], parsedParts[1]);
}
```

`Planet` struktura sayyoraning markazini (`Point` ko'rinishida) va radiusini saqlaydi. Bu strukturada quyidagi muhim jihatlar mavjud:

1. **Ikki xil konstruktor**: 
   - Birinchisi to'g'ridan-to'g'ri `Point` va `radius` qabul qiladi.
   - Ikkinchisi satr ko'rinishidagi ma'lumotlarni qabul qiladi va ularni ajratib oladi.

2. **Lambda expression va LINQ**: Ikkinchi konstruktorda satrni ajratish va qiymatlarni o'zlashtirishda lambda ifoda va LINQ-dan foydalanilgan. Bu kod qisqaroq va o'qishli bo'lishiga yordam beradi.

3. **Contains metodi**: Bu metod Pifagor teoremasidan foydalanib, berilgan nuqta sayyora ichida yoki chegarasida joylashganligini tekshiradi. Lambda ifoda yordamida bir qatorda yozilgan.

### Program sinfi

```csharp
@Program.cs @Point.cs @Planet.cs as context, explain the problem solution and struct design choices in uzbek in @Readme.md file in a blog post format.

Certainly! I'll create a blog post in Uzbek explaining the problem solution and struct design choices for the given code. I'll add this content to the Day3/Readme.md file.
csharp
public readonly struct Point(int x, int y)
{
public int X { get; init; } = x;
public int Y { get; init; } = y;
}
csharp
public readonly struct Planet(Point center, int radius)
{
public Point Center { get; init; } = center;
public int Radius { get; init; } = radius;
public Planet(string? parts) : this(new(), 0) =>
(Center, Radius) = parts?.Split(' ', StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray() is var parsedParts ?
(new Point(parsedParts[0], parsedParts[1]), parsedParts[2]) :
(new Point(), 0);
public bool Contains(Point point) =>
Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
}
I've added this blog post in Uzbek to the Day3/Readme.md file, explaining the problem solution and struct design choices. The post covers the problem description, solution structure, and detailed explanations of each struct and the main program logic.
@Codebase this @Readme.md file doesnt explain the sultion and design choices in broader detail.

Exipalin it in broader detail focusing on each important code chunk, what it does and why it was written like that. 

Certainly! I'll provide a more detailed explanation of the solution and design choices, focusing on important code chunks. I'll update the Readme.md file with this broader explanation.
csharp
public readonly struct Point(int x, int y)
{
public int X { get; init; } = x;
public int Y { get; init; } = y;
}
csharp
public readonly struct Planet(Point center, int radius)
{
public Point Center { get; init; } = center;
public int Radius { get; init; } = radius;
public Planet(string? parts) : this(new(), 0) =>
(Center, Radius) = parts?.Split(' ', StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray() is var parsedParts ?
(new Point(parsedParts[0], parsedParts[1]), parsedParts[2]) :
(new Point(), 0);
public bool Contains(Point point) =>
Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
}
csharp
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

```

`Program` sinfi asosiy dastur mantiqini o'z ichiga oladi. Bu sinfda quyidagi muhim jihatlar mavjud:

1. **Test holatlarni boshqarish**: `while` tsikli yordamida har bir test holat uchun alohida hisob-kitob amalga oshiriladi.

2. **LINQ va lambda ifodalar**: Kiritilgan ma'lumotlarni qayta ishlash uchun LINQ va lambda ifodalardan foydalanilgan. Bu kod qisqaroq va tushunarli bo'lishiga yordam beradi.

3. **XOR operatori**: Shahzoda va malikaning sayyora ichida yoki tashqarisida ekanligini tekshirish uchun XOR (`^`) operatoridan foydalanilgan. Bu usul juda samarali, chunki:
   - Agar ikkalasi ham ichkarida yoki tashqarida bo'lsa, natija `false` bo'ladi.
   - Agar biri ichkarida, ikkinchisi tashqarida bo'lsa, natija `true` bo'ladi.

4. **Ternary operator**: Kesishishlar sonini oshirish uchun ternary operatordan foydalanilgan. Bu ham kodni qisqartirish va o'qishli qilish uchun ishlatilgan.

## Xulosa

Bu yechim bir nechta zamonaviy C# xususiyatlaridan foydalangan holda samarali va tushunarli kod yozishga imkon beradi:

1. **Strukturalar**: Value type sifatida ishlashi tufayli xotira samaradorligini oshiradi.
2. **Readonly strukturalar**: Immutability ta'minlaydi va xatolarni kamaytiradi.
3. **Lambda ifodalar va LINQ**: Kodni qisqartiradi va o'qishli qiladi.
4. **Pattern matching**: Kod mantiqini soddalashtirishga yordam beradi.
5. **XOR operatori**: Samarali mantiqiy tekshiruvlar uchun ishlatilgan.

Bu yondashuv nafaqat masalani hal qiladi, balki kodni kelajakda oson kengaytirish va saqlash imkonini ham beradi.

Umid qilamanki, bu batafsil tushuntirish sizga masala va uning yechimi haqida yanada chuqurroq tushuncha berdi. Savollaringiz bo'lsa, bemalol so'rang!