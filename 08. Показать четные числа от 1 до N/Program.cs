// Показать четные числа от 1 до N

Console.WriteLine("Введите длину: ");
int n = int.Parse(Console.ReadLine());
Console.Clear();
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.Write($"{i} ");