/*
Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();

Console.WriteLine("Введите любое число: ");
string third = Console.ReadLine();
int thirdNum = int.Parse(third);
Console.WriteLine(thirdNum>99 ? thirdNum.ToString()[2] : "Третьего числа нет");
