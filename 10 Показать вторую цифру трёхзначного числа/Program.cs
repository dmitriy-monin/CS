// Показать вторую цифру трёхзначного числа

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
string valueStr = Console.ReadLine();
if (int.TryParse(valueStr, out int valueInt))
    if (valueInt>99 && valueInt<1000)
        Console.WriteLine("Вторая цифра: " + valueInt%100/10);
    else
        Console.WriteLine("Ошибка! Это не трехзначное число!");
else Console.WriteLine("Ошибка! Это не число!");