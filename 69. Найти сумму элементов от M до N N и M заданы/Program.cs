// Найти сумму элементов от M до N, N и M заданы

Console.Clear();
Console.Write("Введите число M (начальное число): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N (конечное число): ");
int n = int.Parse(Console.ReadLine());

int SumRec(int n, int m)
{
    if (n == m) return m;
    else if (m < n) return n + SumRec(n - 1, m);
    else return 0;
}

Console.WriteLine(SumRec(n, m));