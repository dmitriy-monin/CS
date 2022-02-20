// 34. Написать программу замену элементов массива на противоположные

// С противоположным знаком?

int GetIntFromConsole()
{
    Console.Write("Введите число от 1 до 10: ");
    string input1 = Console.ReadLine();
    string error = "0";
    if (int.TryParse(input1, out int input) && input>=1 && input<=10)
        return input;
    else return int.Parse(error);
}

int[] ArrayInit(int num)
{
    int[] array = new int[num];
    Random  rand = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(-10,10);    
    }
    return array;
}

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        
    }
}

void ArrayPrintNeg(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
        Console.Write($"{array[i]} ");
    }
}
Console.Clear();
int getInt = GetIntFromConsole();
int[] array = ArrayInit(getInt);
ArrayPrint(array);
ArrayPrintNeg(array);
