// Показать последнюю цифру трёхзначного числа

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра: " + a%10);