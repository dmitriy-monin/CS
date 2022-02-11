// Удалить вторую цифру трёхзначного числа

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
