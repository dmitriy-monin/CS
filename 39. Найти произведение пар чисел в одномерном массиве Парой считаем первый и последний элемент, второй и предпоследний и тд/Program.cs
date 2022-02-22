// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 };

int sum = 0;

for (int i = 0; i < arr.Length / 2; i++)
{
    sum += arr[i] * arr[arr.Length - 1 - i];
    Console.WriteLine(sum);
}