// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();

bool[] arrayX = {false, true};
bool[] arrayY = {false, true};
bool flag = true;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        bool f1 = !(arrayX[i] || arrayY[j]);
        bool f2 = (!arrayX[i] && !arrayY[j]);
        if (f1 != f2)
        {
            flag = false;
        }
        Console.WriteLine("{0,8} {1,8} {2,8} {3,8}", arrayX[i], arrayY[j], f1, f2);
        Console.WriteLine();
    }
}
if (flag == true)
    Console.WriteLine("Выражение верно для всех значений X и Y");
else
    Console.WriteLine("Выражение неверно для всех значений X и Y");