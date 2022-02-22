// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.Write("Введите четверть от 1 до 4: ");
string x = Console.ReadLine();
 
void Execute()
{
    if (int.TryParse(x, out int y))
        if (y==1)
            Console.WriteLine("x>0, y>0");
        else if (y==2)
            Console.WriteLine("x<0, y>0");
        else if (y==3)
            Console.WriteLine("x<0, y<0");
        else if (y==4)
            Console.WriteLine("x>0, y<0");
        else 
            Console.WriteLine("Ошибка! Такой четверти не существует! Нужно ввести число от 1 до 4");
    else Console.WriteLine("Ошибка! Такой четверти не существует! Нужно ввести число от 1 до 4");
}
Execute();