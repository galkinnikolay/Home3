// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number > 0 && number < 99)
{
Console.WriteLine("Третьей цифры нету");
}
else if (number > 100 && number < 999)
{
int t100 = (number % 10);
Console.WriteLine("Вывод числа: " + t100);
}
else if (number > 1000 && number < 9999)
{
int t1000 = ((number / 10)%10);
Console.WriteLine("Вывод числа: " + t1000);
}
else if (number > 10000 && number < 99999)
{
int t10000 = ((number / 100)%10);
Console.WriteLine("Вывод числа: " + t10000);
}