// 60. Составить частотный словарь элементов двумерного массива

int[] array = new int[] { 1, 9, 9, 9, 2, 8, 0, 9, 7, 7, 5, 4, 8};

Dictionary<int, int> Execut()
{
    Dictionary<int, int> dic = new Dictionary<int, int>();      // Создаем словарь
    for (int i = 0; i < array.Length; i++)
    {
        if (dic.ContainsKey(array[i]))                          // Проверяем есть ли такой ключ в словаре (в данном случае элементы массива)
            dic[array[i]] = dic[array[i]] + 1;                  // Если есть данный ключ то обращаемся к нему и прибавляем значение
        else
            dic.Add(array[i], 1);                               // Если нет, то создаем этот ключ и присваиваем ему значение
    }
    return dic;
}

void PrintDic(Dictionary<int, int> dicc)
{
    foreach (var item in dicc)
    {
        Console.WriteLine($"{item.Key} встречается {item.Value} раз");     // item.Key обращаемся к нашему ключу
    }                                                                      // item.Value это значение
}

Console.Clear();

PrintDic(Execut());