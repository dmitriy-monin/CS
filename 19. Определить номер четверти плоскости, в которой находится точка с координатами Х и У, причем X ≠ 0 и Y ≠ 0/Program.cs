// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int InPut(string message)
{
    Console.WriteLine(message);
    string num = Console.ReadLine();
    return int.Parse(num);
}

void Execute(int x, int y)
{
    if (x>0 && y>0)
        Console.WriteLine("Точка в I четверти");
    else if (x<0 && y>0)
        Console.WriteLine("Точка во II четверти");
    else if (x<0 && y<0)
        Console.WriteLine("Точка в III четверти");
    else if (x>0 && y<0)
        Console.WriteLine("Точка в IV четверти");
    else if (x==0 && y==0)
        Console.WriteLine("Точка в начале координат");
    else 
        Console.WriteLine("Точка вне четверти, а на оси координат");
}
Console.Clear();
int x = InPut("Введите координаты точки X: ");
int y = InPut("Введите координаты точки Y: ");
Execute(x,y);