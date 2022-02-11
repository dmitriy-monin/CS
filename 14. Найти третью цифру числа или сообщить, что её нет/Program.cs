// Найти третью цифру числа или сообщить, что её нет

Console.Clear();
Console.WriteLine("Введите число: ");
string valueStr = Console.ReadLine();
 
if (int.TryParse(valueStr, out int valueInt))   // проверяем, что введено число, а не буквы. преобразовывая строку в число 
{
    string resultValue = valueInt.ToString();   // преобразовываем из числа обратно строку для того чтобы отбросить нули перед числом, если они есть
    if (resultValue.Length>=3)                  // проверяем, что в числе не меньше 3х цифр
        Console.WriteLine($"Третья цифра числа: {resultValue[2]}");
    else Console.WriteLine("В числе меньше трех цифр");
}
else Console.WriteLine("Вы ввели не число");


// int.Parse("123") возвращает int
// Convert.ToInt32("123") возвращает int
// int.TryParse("123", out int b) возвращает тип bool