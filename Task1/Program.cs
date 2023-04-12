static void Recurs(int n)
{
    if (n < 0)
    {
        Console.WriteLine("Вы ввели ненатуральное число!");
    }
    if (n == 0)
    {
        return;
    }
    Console.WriteLine(n);
    Recurs(n - 1);
}
void Main()
{
    Console.Write("Введите число N: ");
    int n = Int32.Parse(Console.ReadLine());
    Recurs(n);
}

Main();