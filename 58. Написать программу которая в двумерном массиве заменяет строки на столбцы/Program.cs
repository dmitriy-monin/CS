// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

int[,] array = new int[5, 5];
int[,] matrix = new int[5, 5];


void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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

void SwapMatrix()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            matrix[i, j] = array[j, i];
        }
    }
    Console.WriteLine();
}

Console.Clear();
if (array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("Матрица не квадратная");
}
else
{
    FillArray();
    PrintArray(array);
    SwapMatrix();
    PrintArray(matrix);
}

