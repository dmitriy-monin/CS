// 41. Выяснить являются ли три числа сторонами треугольника
// Теорема о неревенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Получаем три числа

int GetRandomNumber()
{
    int randomNumber = new Random().Next(1, 100);
    return randomNumber;
}

// Сравниваем число с суммой остальных

bool SumTwoNumber(int a, int b, int c)
{
    return a < (b + c);
}

int numberOne = GetRandomNumber();
int numberTwo = GetRandomNumber();
int numberThree = GetRandomNumber();
Console.WriteLine($"{numberOne}, {numberTwo}, {numberThree}");

if (SumTwoNumber(numberOne, numberTwo, numberThree)
    && SumTwoNumber(numberTwo, numberOne, numberThree)
    && SumTwoNumber(numberThree, numberOne, numberTwo))
    Console.WriteLine("Числа являются сторонами треугольника");
else Console.WriteLine("Числа не являются сторонами треугольника");