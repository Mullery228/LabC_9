
Console.WriteLine("Введите натуральное число M и N:");
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от M до N = {Recurs(M, N)}");

static int Recurs(int m, int n)
{
    if (m == 0)
    {
        return (n * (n + 1)) / 2;
    }
    else if (n == 0)
    {
        return (m * (m + 1)) / 2;
    }
    else if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return n + Recurs(m, n - 1);
    }
    else
    {
        return n + Recurs(m, n + 1);
    }
}