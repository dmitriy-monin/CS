﻿// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, 
// что такого элемента нет

var arr = new int [10,10];

Random randomNumber = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=randomNumber.Next(1,101);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr=Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            checkStatus=false;
            break;
        }
        else
            Console.WriteLine("Ошибка! Вы ввели не число!");
    }
    return numberInt;
}

void SearchNumber(int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j]==number)
            {
                Console.WriteLine($"Число {number} присутствует в массиве {i},{j}");
                return;
            }
        }
    }
    Console.WriteLine("Такого числа не найдено!");
}

FillArray();
PrintArray();
int inputNumber=GetNumber("Введите число: ");
SearchNumber(inputNumber);
