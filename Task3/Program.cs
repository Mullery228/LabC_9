
Console.WriteLine("Введите числа N и M:");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат = {Recurs(M, N)}");

static int Recurs(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return Recurs(n - 1, 1);
        }
        else
        {
            return Recurs(n - 1, Recurs(n, m -1));
        }
    }
}