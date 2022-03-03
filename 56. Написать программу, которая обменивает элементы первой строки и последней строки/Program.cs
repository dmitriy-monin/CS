// 56. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] array = new int[5, 6];

void GetArray()
{
    Random number = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    Random number = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SwapArray()
{
    int lastStr = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int saveNum = array[0, i];
        array[0, i] = array[lastStr, i];
        array[lastStr, i] = saveNum;
    }
}

Console.Clear();
GetArray();
PrintArray(array);
SwapArray();
Console.WriteLine();
PrintArray(array);