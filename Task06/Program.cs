﻿// Задача №6:

// Напишите программу, которая на 
// 1.вход принимает число 
// 2.выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine($"Число {num1} четное");
}
else
{
    Console.WriteLine($"Число {num1} нечетное");
}