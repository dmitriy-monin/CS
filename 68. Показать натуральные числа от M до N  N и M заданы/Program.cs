// Показать натуральные числа от M до N, N и M заданы

Console.Clear();
Console.Write("Введите число M (начальное число): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N (конечное число): ");
int n = int.Parse(Console.ReadLine());

string NumbersRec(int m, int n)
{
    if (m <= n) return $"{m} " + NumbersRec(m + 1, n);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(m, n));