// По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();
Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
if (a==Math.Pow(b,2))
    Console.WriteLine("Первое число является квадратом второго!");
else 
    Console.WriteLine("Первое число НЕ является квадратом второго!");