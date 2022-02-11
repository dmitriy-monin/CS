// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

void ErrorEnter()
{
    Console.WriteLine("Нужно ввести число от 1 до 7. Нажмите любую клавишу для повтора");
    Console.ReadLine();
    EnterValue();
}

void EnterValue()
{
    Console.Clear();
    Console.WriteLine("Введите число, обозначающее день недели ");
    string valueStr = Console.ReadLine();

    if (int.TryParse(valueStr, out int valueInt))   // проверяем, что введено число, а не буквы. преобразовывая строку в число 
    {
        if (valueInt>=1 && valueInt<8)
            {
                if (valueInt>5 && valueInt<8)
                    Console.WriteLine("Номер дня недели " + valueInt + " соответствует выходному дню");
                else Console.WriteLine("Номер дня недели " + valueInt + " не соответствует выходному дню");
            }
        else ErrorEnter(); 
    }
    else Console.WriteLine("Вы ввели не число");
}
EnterValue();