Console.WriteLine("Write n: ");
int number = int.Parse(Console.ReadLine());

double a = 0, b = 0, c = 0;

int factorial = 1;
for (int i = 1; i <= number; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + (1 / Math.Pow(i, 2));
    for (int j = 1; j <= i; j++)
    {
        factorial *= j;
    }
    
    c += factorial;
    factorial = 1;
}

Console.WriteLine($"{a}");
Console.WriteLine($"{b}");
Console.WriteLine($"{c}");
