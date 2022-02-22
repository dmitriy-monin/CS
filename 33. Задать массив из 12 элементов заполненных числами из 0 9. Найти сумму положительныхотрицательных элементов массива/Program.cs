// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

Console.Clear();
int[] arr = new int[12];
int sumPos = 0;
int sumNeg = 0;

Random rand = new Random();
Console.Write("Создан массив: ");

for (int i = 0; i < 12; i++)
{
    arr[i] = rand.Next(-9, 10);
    Console.Write($"{arr[i]} ");
    if (arr[i] > 0)
        sumPos = sumPos + arr[i];
    else
        sumNeg = sumNeg + arr[i];
}

Console.WriteLine("\nСумма положительных чисел = " + sumPos);
Console.WriteLine("Сумма отрицательных чисел = " + sumNeg);