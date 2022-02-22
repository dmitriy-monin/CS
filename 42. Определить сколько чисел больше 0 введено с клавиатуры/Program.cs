// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
int count = 0;
Console.Write("Введите любое число: ");
string s1 = Console.ReadLine();

if (int.TryParse(s1, out int s))
{
    while (s > 0)
    {
        if (s % 10 != 0) count = count + 1;
        s = s / 10;
    }
    Console.WriteLine("Больше нуля введено " + count + " чисел.");
}
else
    System.Console.WriteLine("Ошибка! Введены неверные данные!");