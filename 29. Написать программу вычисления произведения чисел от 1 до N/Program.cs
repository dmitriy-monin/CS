// 29. Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

int InPut(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    int a = int.Parse(num);
    return a;
}


int Multiple(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = i * result;
    }
    return result;
}

int number = InPut("Введите число N: ");
int resultOfMultiple = Multiple(number);
Console.WriteLine("Произведение чисел = " + resultOfMultiple);