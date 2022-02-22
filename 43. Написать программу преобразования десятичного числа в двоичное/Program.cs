// 43. Написать программу преобразования десятичного числа в двоичное

Console.Clear();
int number = 0;
int InPut()
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
}
number = InPut();
while (number != 0)
{
    Console.Write(number % 2);
    number=number/2;
}
