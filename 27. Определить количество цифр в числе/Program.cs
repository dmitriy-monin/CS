// 27. Определить количество цифр в числе

int GetNumber()
{
    int rand = new Random().Next(100, 1000000);
    return rand;
}

int number = GetNumber();
Console.WriteLine(number);
int count = 0;

while (number != 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine("В числе " + count + " цифр(ы)");