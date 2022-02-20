// 24. Найти кубы чисел от 1 до N

Console.Clear();
Console.Write("Введите число > 1: ");
string y = Console.ReadLine();

int [] InitArray(int x)
{
    int [] array = new int[x];
    for (int i=0; i<x; i++)
        array[i]=(i+1)*(i+1)*(i+1);
    return array;
}
void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.WriteLine(array[i]);
}

if (int.TryParse(y, out int x) && x>0)
{   
    var array = InitArray(x);
    PrintArray(array);
}
else
    System.Console.WriteLine("Ошибка! Введены неверные данные!");