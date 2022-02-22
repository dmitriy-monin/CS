// 28. Подсчитать сумму цифр в числе

int GetNumber()
{
    int rand = new Random().Next(10, 1000000000);
    return rand;
}

Console.Clear();
int number = GetNumber();
Console.WriteLine(number);
int count = 0;
int sum = 0;

while (number != 0)
{
    sum = number % 10 + sum;
    number = number / 10;
    count++;
}
Console.WriteLine("Сумма цифр числа = " + sum);



