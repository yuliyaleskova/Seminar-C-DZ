// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите  число 1 ->");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите  число 2 ->");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     System.Console.WriteLine($"большее число {num1} + меньшее число {num2}");
// }
// else
// {
//     System.Console.WriteLine($"большее число {num2},меньшее число {num1}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите  число 1 ->");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число 2 ->");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число 3 ->");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num2>max) max=num2;
if(num3>max) max=num3;

Console.Write("max=");
Console.WriteLine(max);






