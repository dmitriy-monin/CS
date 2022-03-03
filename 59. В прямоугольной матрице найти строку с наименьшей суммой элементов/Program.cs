// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов


int[,] array = new int[5, 6];
Random rand = new Random();

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray()
{
    Console.WriteLine("Задан массив:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumMin()
{
    int a = 0;
    int sum = 0;
    int min = 0;
    int[] temp = new int[array.GetLength(0)];

    Console.WriteLine("Cумма строк массива:");
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        temp[i] = sum;
        Console.WriteLine($"Строка {i+1} = {temp[i]}");
        sum = 0;
    }
    min = temp[0];
    for (int i = 1; i < temp.Length; i++)
    {
        if (temp[i] < min)
        {
            min = temp[i];
            a = i;
        }

    }

    Console.WriteLine($"\nСтрока с наименьшей суммой - {a+1}");
}

Console.Clear();
FillArray();
PrintArray();
SumMin();
