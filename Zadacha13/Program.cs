// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number < 100)
{
     Console.WriteLine("Третьей цифры нету");
}
else if (number < 999)
{
    int t = (number % 10);
    Console.WriteLine("Вывод числа: " + t);
}
else if (number > 1000)
{
    int t = ((number / 10)%10);
    Console.WriteLine("Вывод числа: " + t);
}