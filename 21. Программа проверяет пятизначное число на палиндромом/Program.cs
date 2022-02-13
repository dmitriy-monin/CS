// 21. Программа проверяет пятизначное число на палиндромом.

Console.Clear();

int InPut(string message)
{
    Console.WriteLine(message);
    string num = Console.ReadLine();
    int a = int.Parse(num);
    return a;
}

int numOne = InPut("Введите пятизначное число: ");
bool valueOne=numOne%10==numOne/10000;
bool valueTwo=(numOne%100)/10==(numOne/1000)%10;
if (valueOne && valueTwo)
    System.Console.WriteLine("Число является палиндромом");
else
    System.Console.WriteLine("Число не является палиндромом");