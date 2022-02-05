// Выяснить является ли число чётным

bool OddOrEven(int a)
{
    return a%2==0;
}
OddOrEven(8);
if (OddOrEven(8)) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");