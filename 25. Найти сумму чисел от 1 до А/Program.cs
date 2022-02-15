// 25. Найти сумму чисел от 1 до А

Console.Clear();

int InPut(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    int a = int.Parse(num);
    return a;
}

int number = InPut("Введите число до которго нужно найти сумму: ");
int sum = 0;

for (int i = 0; i <= number; i++)
{
    sum += i;
}

Console.WriteLine("Сумма всех чисел до требуемой: " + sum);