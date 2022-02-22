// 23. Показать таблицу квадратов чисел от 1 до N

Console.Clear();

int InPut(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    int.Parse(num);
    return int.Parse(num);
}
int [] InitArray(int number)
{
    int [] array = new int[number];
    for (int i=0; i<number; i++)
        array[i]=(i+1)*(i+1);
    return array;
}
void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.WriteLine(array[i]);
}
int b =InPut("Введите число > 1: ");
var array = InitArray(b);
PrintArray(array);