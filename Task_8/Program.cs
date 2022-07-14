/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string first = Console.ReadLine();
int firstnumber = int.Parse(first);

Console.Clear();
Console.WriteLine($"Все четные числа от 1 до {firstnumber}");    
for (int i = 1; i < firstnumber+1; i++)
if (i%2==0) {
    Console.WriteLine(i);
}

       
