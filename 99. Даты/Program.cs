// Есть две даты, нужно вывести на экран количество полных лет. Количество полных дней. И показать кто из них старше и насколько

DateTime firstData = new DateTime(1950, 01, 01);
DateTime secondData = new DateTime(1971, 01, 01);

Console.WriteLine($"Первая дата - {firstData.ToShortDateString()}");

Console.WriteLine($"Вторая дата - {secondData.ToShortDateString()}");

DateTime today = DateTime.Now;

int oldFirst = today.Year - firstData.Year;
int oldSecond = today.Year - secondData.Year;

Console.WriteLine();
Console.WriteLine($"Лет первому - {oldFirst}");
Console.WriteLine($"Лет второму - {oldSecond}");

if (oldFirst > oldSecond)
    Console.WriteLine($"Первый старше на {oldFirst - oldSecond}");
else
    Console.WriteLine($"Второй старше на {oldSecond - oldFirst}");

int countOfDaysFirst = 0;
int countOfDaysSecond = 0;

for (int i = 0; i < oldFirst; i++)
{
    countOfDaysFirst += 365;
}

for (int i = 0; i < oldSecond; i++)
{
    countOfDaysSecond += 365;
}

Console.WriteLine($"Дней у первого = {countOfDaysFirst}, дней у второго = {countOfDaysSecond}");

var diff = (DateTime.Now - firstData).TotalDays;
Console.WriteLine($"Всего дней - {diff}");