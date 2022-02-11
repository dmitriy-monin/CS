// Удалить вторую цифру трёхзначного числа

// int a = 0;
// string s = string.Empty;

// System.Console.Write("Введите трехзначное число ");
// s = Console.ReadLine();
// a = s.Length;

// if(a == 3) 
// {
//     System.Console.WriteLine("Удаляем цифру " + s[s.Length-2] + ", получаем " + s[s.Length-3] + s[s.Length-1]);
// }
// else System.Console.WriteLine("Число не является трехзначным");

Console.Clear();
Console.WriteLine("Введите число: ");
string valueStr = Console.ReadLine();
 
if (int.TryParse(valueStr, out int valueInt))   // проверяем, что введено число, а не буквы. преобразовывая строку в число 
{
    string resultValue = valueInt.ToString();   // преобразовываем из числа обратно строку для того чтобы отбросить нули перед числом, если они есть
    if (resultValue.Length==3)                  // проверяем, что число трехзначное
        Console.WriteLine("Удаляем цифру " + resultValue[1] + " получаем " + resultValue[0] + resultValue[2]);
    else Console.WriteLine("Число не является трехзначным");
}
else Console.WriteLine("Вы ввели не число");
