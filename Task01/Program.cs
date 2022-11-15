// Задача1.
// Напишите программу, которая 
// 1.на вход принимает два числа 
// 2.проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите число первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1 == num2 * num2) Console.Write($"Число {num2} является квадратом числа {num1}");

else Console.Write($"Число {num2} не является квадратом числа {num1}");