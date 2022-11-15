// Задача №3
// Напишите программу, которая на 
// 1. вход принимает одно число (N)
// 2. а на выходе показывает все целые
// числа в промежутке от -N до N.
// Пример:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = -num1;

while (count <= num1)
{
    Console.WriteLine(count);
    count++;
}