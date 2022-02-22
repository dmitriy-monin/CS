// Даны 2 числа. Показать большее и меньшее число

Console.Clear();
Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
if (a>b) Console.WriteLine($"{a} больше чем {b}");
if (a<b) Console.WriteLine($"{a} меньше чем {b}");
if (a==b) Console.WriteLine("Числа равны!");
