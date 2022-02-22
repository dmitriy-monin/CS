// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();

int[] arr = new int[10];
Random rand = new Random();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 100);
    Console.Write($"{arr[i],3}");
    if (i % 2 != 0) count = count + arr[i];
}
Console.WriteLine($"\nСумма чисел, стоящих на нечетных позициях массива = {count}");