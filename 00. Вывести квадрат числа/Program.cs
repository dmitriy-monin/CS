// Вывести квадрат числа

Console.Clear();
Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine($"{a}^2 = {Math.Pow(a,2)}");