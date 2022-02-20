// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] ArrayInit(int num)
{
    int[] array = new int[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(0, 2);
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
int[] array = ArrayInit(8);
ArrayPrint(array);