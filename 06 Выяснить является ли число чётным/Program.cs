// Выяснить является ли число чётным

Console.Clear();
int number = new Random().Next(1,100);
Console.WriteLine("Число: " + number);
if (number%2 == 0)
    Console.WriteLine("Чётное");
else
    Console.WriteLine("Нечётное");