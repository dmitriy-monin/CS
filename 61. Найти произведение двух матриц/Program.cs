// 61. Найти произведение двух матриц

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
Random rand = new Random();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],2} |");
        }
        Console.WriteLine();
    }
}


int[,] SumMatrix(int[,] arr1, int[,] arr2)
{
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int n = 0; n < arr1.GetLength(1); n++)
            {
                sum = sum + arr1[i, n] * arr2[n, j];
            }
            matrix[i, j] = sum;
            sum = 0;
        }
    }
    return matrix;
}

Console.Clear();
FillArray(matrix1);
PrintArray(matrix1);
FillArray(matrix2);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц равно:");
PrintArray(SumMatrix(matrix1, matrix2));