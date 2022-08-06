/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("Введите любое число: ");
string anyNum = Console.ReadLine();
int dayNum = int.Parse(anyNum);

if(dayNum == 6 || dayNum == 7) {
    Console.WriteLine("Сегодня выходной день!");
}
else if(dayNum > 7 || dayNum < 1) {
    Console.WriteLine("Такого дня недели не существует!");
}
else {
    Console.WriteLine("Сегодня будний день!");
}