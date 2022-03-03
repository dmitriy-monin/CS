// Показать натуральные числа от N до 1, N задано


Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string NumbersRec(int n)
{
    if (n >= 1) return $"{n} " + NumbersRec(n - 1);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(n));