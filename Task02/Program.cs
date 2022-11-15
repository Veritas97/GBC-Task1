// Задача 2.
// Напишите программу, которая 
// 1. будет выдавать название дня недели 
// 2. по заданному номеру.
// пример:
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число дня недели: ");
int num1 = Convert.ToInt32 (Console.ReadLine());

if (num1 == 1) Console.Write("Ваш день: Понедельник");
if (num1 == 2) Console.Write("Ваш день: Вторник");
if (num1 == 3) Console.Write("Ваш день: Среда");
if (num1 == 4) Console.Write("Ваш день: Четверг");
if (num1 == 5) Console.Write("Ваш день: Пятница");
if (num1 == 6) Console.Write("Ваш день: Суббота");
if (num1 == 7) Console.Write("Ваш день: Воскресенье");
if (num1 >= 8) Console.Write("Такого дня не существует");