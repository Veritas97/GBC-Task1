// Задача 4: 
// Напишите программу, которая на 
// 1. вход принимает два числа 
// 2. и выдаёт, какое число большее, а какое меньшее.

// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2) Console.Write($"Большее число {num2}");
if (num2 < num1) Console.Write($"Большее число {num1}");