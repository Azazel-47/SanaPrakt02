Console.WriteLine("Write 5 points from 1 to 5");
int point, sum = 0;
double avrg;

for (int i = 0; i < 5; i++)
{
    point = int.Parse(Console.ReadLine());
    if (point > 5)
    {
        Console.WriteLine("Error, your point can not be higher then 5");
        break;
    }
    sum += point;
}

avrg = (sum * 1.0) / 5;
// Console.WriteLine($"{sum}\n");
// Console.WriteLine($"{avrg}");
if (avrg >= 4.0)
{
    Console.WriteLine($"My congratulations! Your point is {avrg}");
}
else
{
    Console.WriteLine($"Sorry :( Your point is only {avrg}");
}
