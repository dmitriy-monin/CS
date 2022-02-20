// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();
int[] arr = new int[20];
int sumPos = 0;
int sumNeg = 0;

Random rand = new Random();
Console.Write("Создан массив: ");

for (int i = 0; i < 20; i++)
{
    arr[i] = rand.Next(100, 1000);
    Console.Write($"{arr[i]} ");
    if (arr[i]%2 == 0)
        sumPos = sumPos + 1;
    else
        sumNeg = sumNeg + 1;
}

Console.WriteLine("\nКоличество четных чисел = " + sumPos);
Console.WriteLine("Количество нечетных чисел = " + sumNeg);