// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] array = new double[10, 10];
Random rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * 100;
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],0:F2} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
FillArray();
PrintArray();