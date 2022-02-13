// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

int InPut(string message)
{
    Console.WriteLine(message);
    string num = Console.ReadLine();
    int a = int.Parse(num);
    return a;
}

int numOne = InPut("Введите первое число: ");
int numTwo = InPut("Введите второе число: ");

if (numOne == numTwo*numTwo)
    System.Console.WriteLine("Первое число " + numOne + " является квадратом второго числа " + numTwo);
else if (numTwo == numOne*numOne)
    Console.WriteLine("Второе число " + numTwo + " является квадратом первого числа " + numOne);
else 
    Console.WriteLine("Данные числа не является квадратом друг друга");