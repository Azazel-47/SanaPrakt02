
Console.WriteLine("Write a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Write c");
int c = int.Parse(Console.ReadLine());
double x1, x2;

double d = b * b - 4 * a * c;
Console.WriteLine($"D = {d}");
if (d == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"x = {x1}");
} else if (d > 0)
{
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"x1 = {x1}\n");
    Console.WriteLine($"x2 = {x2}\n");
}
else
{
    Console.WriteLine("D < 0");
}

