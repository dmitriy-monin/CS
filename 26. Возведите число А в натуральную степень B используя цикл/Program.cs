// 26. Возведите число А в натуральную степень B используя цикл

Console.Clear();

Console.Write("Введите число A: ");
string a = Console.ReadLine();
Console.Write("Введите степень в которую нужно возвести число А: ");
string b = Console.ReadLine();
string sum = a;

if (double.TryParse(a, out double a1) && a1 > 0 && int.TryParse(b, out int b1) && b1 > 0 && double.TryParse(sum, out double sum1))

    for (int i = 1; i < b1; i++)
    {
        sum1 = a1 * sum1;
        System.Console.WriteLine($"{sum1,0:F2}");
    }
else
    Console.WriteLine("Ошибка! Введены неверные данные!");