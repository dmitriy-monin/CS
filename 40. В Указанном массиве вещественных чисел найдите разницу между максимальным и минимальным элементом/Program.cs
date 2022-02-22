// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] arr = new double[] { 7.34, 5.67, 2.27, 4.64, 9.43, 6.33 };
double min = arr[0];
double max = arr[0];

Console.Write("Задан массив: ");

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

Console.WriteLine($"\nРазница между максимальным и минимальным элементом = {max - min,0:F2}");