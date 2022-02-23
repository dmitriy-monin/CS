﻿// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] array = new int[5, 6];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 100);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
FillArray();
PrintArray();