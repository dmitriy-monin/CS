// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}
Console.Write(Akkerman(n, m));