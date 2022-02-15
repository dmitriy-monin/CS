// 31. Задать массив из 8 элементов и вывести их на экран

int GetIntFromConsole()
{
    Console.Write("Введите число от 1 до 10: ");
    string input = Console.ReadLine();
    return int.Parse(input);
}

int[] ArrayInit(int num)
{
    int[] array = new int[num];
    Random  rand = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(1,10);    
    }
    return array;
}

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Clear();
int getInt = GetIntFromConsole();
int[] array = ArrayInit(getInt);
ArrayPrint(array);