/*
 Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/ 

Console.WriteLine("Введите число");
string first = Console.ReadLine();
int firstnumber = int.Parse(first);
int secondnumber = firstnumber % 2;
if (secondnumber == 0) {
    Console.WriteLine($"Число {first} является четным");
}
else {
    Console.WriteLine($"Число {first} не является четным");
}



