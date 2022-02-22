// 22. Найти расстояние между точками в пространстве 2D/3D

void SpaceSelection()
{
    Console.WriteLine("Для расчета в 2D нажмите цифру 2. Для расчета в 3D нажмите цифру 3. И нажмите Enter.");
    string a = Console.ReadLine();

    if (int.TryParse(a, out int b))
        if (b==2)
            SpaceTwo();
        else if (b==3)
            SpaceThree();
        else 
        {
            Console.WriteLine("Ошибка! Введены неверные даные!");
            SpaceSelection();
        }
    else 
    {
        Console.WriteLine("Ошибка! Это не цифра!");
        SpaceSelection();
    }
}

void SpaceTwo()
{
    Console.WriteLine("Вы выбрали 2D. Для расчета введите координаты:");
    Console.Write("X1: ");
    string xx1 = Console.ReadLine();
    Console.Write("Y1: ");
    string yy1 = Console.ReadLine();
    Console.Write("X2: ");
    string xx2 = Console.ReadLine();
    Console.Write("Y2: ");
    string yy2 = Console.ReadLine();
    double result = 0;
    
    if (int.TryParse(xx1, out int x1) && int.TryParse(yy1, out int y1) && int.TryParse(xx2, out int x2) && int.TryParse(yy2, out int y2))
    {
        result = Math.Sqrt((Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)));
        System.Console.WriteLine($"{result,0:F2}");
    }
    else 
        Console.WriteLine("Ошибка! Возможно Вы ввели букву!");
}

void SpaceThree()
{
    Console.WriteLine("Вы выбрали 3D. Для расчета введите координаты:");
    Console.Write("X1: ");
    string xx1 = Console.ReadLine();
    Console.Write("Y1: ");
    string yy1 = Console.ReadLine();
    Console.Write("Z1: ");
    string zz1 = Console.ReadLine();
    Console.Write("X2: ");
    string xx2 = Console.ReadLine();
    Console.Write("Y2: ");
    string yy2 = Console.ReadLine();
    Console.Write("Z2: ");
    string zz2 = Console.ReadLine();
    double result = 0;
    
    if (int.TryParse(xx1, out int x1) && int.TryParse(yy1, out int y1) && int.TryParse(zz1, out int z1) && int.TryParse(xx2, out int x2) && int.TryParse(yy2, out int y2) && int.TryParse(zz2, out int z2))
    {
        result = Math.Sqrt((Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)));
        System.Console.WriteLine($"{result,0:F2}");
    }
    else 
        Console.WriteLine("Ошибка! Возможно Вы ввели букву!");
}

Console.Clear();
SpaceSelection();