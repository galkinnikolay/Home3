// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
string text = Console.ReadLine();
int DayOfWeek = Convert.ToInt32(text);

if (DayOfWeek <= 5)
{
Console.WriteLine("Нет");
}
else if (DayOfWeek <= 7)
{
Console.WriteLine("Да");
}