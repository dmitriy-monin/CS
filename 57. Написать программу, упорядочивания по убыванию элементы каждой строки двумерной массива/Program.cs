// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива

int[,] array = new int[5, 5];
Random number = new Random();

void GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SwapArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = array[i, j];
            int nextIndex = j + 1;

            for (nextIndex = 0; nextIndex < array.GetLength(1); nextIndex++)
            {
                if (array[i, nextIndex] < array[i, j])
                {
                    min = array[i, nextIndex];
                    array[i, nextIndex] = array[i, j];
                    array[i, j] = min;
                }
            }
        }
    }
}

Console.Clear();
GetArray();
PrintArray();
SwapArray();
Console.WriteLine();
PrintArray();

