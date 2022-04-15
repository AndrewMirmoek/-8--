double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double d = double.Parse(Console.ReadLine());
double f = double.Parse(Console.ReadLine());
double e = double.Parse(Console.ReadLine());
double g = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double max1 = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), Math.Max(Math.Max(e, f), Math.Max(a, g)));// сравнить с 
double max2 = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), Math.Max(Math.Max(e, f), Math.Max(a, h))); //сравнить с 
double max3 = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), Math.Max(Math.Max(e, a), Math.Max(g, h)));//сравнить с 
double max4 = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), Math.Max(Math.Max(a, f), Math.Max(g, h)));//сравнить с 
double max5 = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, a)), Math.Max(Math.Max(e, f), Math.Max(g, h))); // сиравнить с 
double max6 = Math.Max(Math.Max(Math.Max(a, b), Math.Max(d, a)), Math.Max(Math.Max(e, f), Math.Max(g, h)));// сиравнить с 
double max7 = Math.Max(Math.Max(Math.Max(a, e), Math.Max(d, a)), Math.Max(Math.Max(e, f), Math.Max(g, h)));// сиравнить с b
double max8 = Math.Max(Math.Max(Math.Max(b, e), Math.Max(d, c)), Math.Max(Math.Max(e, f), Math.Max(g, h)));//a
double maxadsolute = Math.Max(Math.Max(Math.Max(max1, max2), Math.Max(max3, max4)), Math.Max(Math.Max(max5, max6), Math.Max(max7, max8)));
double minmax = Math.Min(Math.Min(Math.Min(max1, max2), Math.Min(max3, max4)), Math.Min(Math.Min(max5, max6), Math.Min(max7, max8)));
Console.WriteLine($"Два самых больших числа {minmax} и {maxadsolute}");


double min1 = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, d)), Math.Min(Math.Min(e, f), Math.Min(a, g)));// сравнить с h
double min2 = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, d)), Math.Min(Math.Min(e, f), Math.Min(a, h))); //сравнить с g
double min3 = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, d)), Math.Min(Math.Min(e, a), Math.Min(g, h)));//сравнить с f
double min4 = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, d)), Math.Min(Math.Min(a, f), Math.Min(g, h)));//сравнить с e
double min5 = Math.Min(Math.Min(Math.Min(a, b), Math.Min(c, a)), Math.Min(Math.Min(e, f), Math.Min(g, h))); // сиравнить с d
double min6 = Math.Min(Math.Min(Math.Min(a, b), Math.Min(d, a)), Math.Min(Math.Min(e, f), Math.Min(g, h)));// сиравнить с c
double min7 = Math.Min(Math.Min(Math.Min(a, e), Math.Min(d, a)), Math.Min(Math.Min(e, f), Math.Min(g, h)));// сиравнить с b
double min8 = Math.Min(Math.Min(Math.Min(b, e), Math.Min(d, c)), Math.Min(Math.Min(e, f), Math.Min(g, h)));// сравнить с a
double minabsolute = Math.Min(Math.Min(Math.Min(min1, min2), Math.Min(min3, min4)), Math.Min(Math.Min(min5, min6), Math.Min(min7, min8)));
double maxmin = Math.Max(Math.Max(Math.Max(min1, min2), Math.Max(min3, min4)), Math.Max(Math.Min(min5, min6), Math.Max(min7, min8)));


Console.WriteLine($"Два самыых маленьких числа {maxmin} и {minabsolute}");

Console.WriteLine ("Все работает!");
Console.WriteLine("Все не работает?!");
Console.WriteLine("нужно сравнивать больше чисел");
Console.WriteLine("проект выполнен, больше сравнений не надо");
//не надо исправлять тест