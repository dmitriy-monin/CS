// 47. Написать программу копирования массива

int[] FillArray(int number)
{
    int[] array = new int[number];
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=num.Next(1,50);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i]=arr[i];
        Console.Write($"{copyArray[i]} ");
    }
    return copyArray;
}

int[] arrayOne = FillArray(15);
Console.WriteLine();
int[] arrayCopy = CopyArray(arrayOne);
