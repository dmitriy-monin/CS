// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.Write("Введите число > 1: ");
string y = Console.ReadLine();

int[] InitArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
        array[i] = (i + 1) * (i + 1) * (i + 1);
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            Console.WriteLine(array[i]);
}

if (int.TryParse(y, out int x) && x > 1)
{
    var array = InitArray(x);
    PrintArray(array);
}
else
    System.Console.WriteLine("Ошибка! Введены неверные данные!");
