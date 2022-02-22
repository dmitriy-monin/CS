// 44. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();
Console.Write("Введите k1: ");
string kk1 = Console.ReadLine();
Console.Write("Введите b1: ");
string bb1 = Console.ReadLine();
Console.Write("Введите k2: ");
string kk2 = Console.ReadLine();
Console.Write("Введите b2: ");
string bb2 = Console.ReadLine();

if (double.TryParse(kk1, out double k1)
    && double.TryParse(bb1, out double b1)
    && double.TryParse(kk2, out double k2)
    && double.TryParse(bb2, out double b2))
{
    if (k1 == k2)
        Console.WriteLine("Прямые не пересекаются!");

    double x = (b1 - b2) / (k2 - k1);
    Console.WriteLine("x = " + x);
}
else
    Console.WriteLine("Ошибка! Введены неверные данные!");