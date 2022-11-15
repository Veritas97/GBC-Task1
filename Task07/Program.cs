// Задача №7:

// Напишите программу, которая на 
// 1.вход принимает число (N)
// 2. на выходе показывает все чётные числа от 1 до N.
// Пример: 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
    
for (int num2 = 1; num2 <= num1; num2++)
    if (num2 % 2 == 0)
        Console.WriteLine(num2);