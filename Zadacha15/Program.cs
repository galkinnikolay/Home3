// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
string text = Console.ReadLine();
int DayOfWeek = Convert.ToInt32(text);

if (DayOfWeek <= 0 || DayOfWeek > 7)
{
    Console.WriteLine("Введите от 1 до 7!");
}
else if (DayOfWeek <= 5 )
{
Console.WriteLine("Нет, рабочий день!");
}
else if (DayOfWeek <= 7)
{
Console.WriteLine("Да, выходной день!");
}