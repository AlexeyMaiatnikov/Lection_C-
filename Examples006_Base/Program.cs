int a = new Random().Next(0,20);
int b = new Random().Next(0,20);
int c = new Random().Next(0,20);
int d = new Random().Next(0,20);
int e = new Random().Next(0,20);

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Первое число ");
Console.WriteLine(a);
Console.Write("Второе число ");
Console.WriteLine(b);
Console.Write("Третье число ");
Console.WriteLine(c);
Console.Write("Четвертое число ");
Console.WriteLine(d);
Console.Write("Пятое число ");
Console.WriteLine(e);
Console.Write("Максимальное число ");
Console.WriteLine(max);