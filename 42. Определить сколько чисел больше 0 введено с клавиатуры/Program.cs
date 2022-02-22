// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
int count=0;
int a;
Console.WriteLine("Введите любое число");
string s= Console.ReadLine();
a=Int32.Parse(s);

while (a>0)
{
 if (a%10!=0) count= count+1;
 a=a/10;
}

Console.WriteLine("Больше нуля введено чисел "+ count);