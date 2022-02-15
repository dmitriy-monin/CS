// 35. Определить, присутствует ли в заданном массиве, некоторое число

int[] arr = new int[10];

int InPut()
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
}

void FullArr()
{
    Random number = new Random();
    Console.Write("Задан массив: ");
    for (int i = 0; i < 10; i++)
    {
        arr[i] = number.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
}

// Определяем есть ли в массиве заданный элемент

// bool Search(int num)
// {
//     Console.WriteLine();
//     foreach (int item in arr)
//     {
//         Console.WriteLine($"Число массива {item} заданное число {num}. {item == num}");
//         if (item == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// Console.Clear();
// int number = InPut();
// FullArr();
// bool result = Search(number);
// Console.WriteLine(result);


// Определяем позицию заданного элемента в массиве

void Search(int num)
{
    Console.WriteLine();
    int i=0;
    foreach (int item in arr)
    {
        // Console.WriteLine($"Число массива {item} заданное число {num}. {item == num}");
        if (item == num)
        {
            Console.WriteLine(i);
        }
        i++;
    }
    
}

Console.Clear();
int number = InPut();
FullArr();
Search(number);
