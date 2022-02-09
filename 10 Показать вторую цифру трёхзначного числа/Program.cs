// Показать вторую цифру трёхзначного числа

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a>99 && a<1000)
    Console.WriteLine("Вторая цифра: " + a%100/10);
else
    Console.WriteLine("Ошибка! Это не трехзначное число!");