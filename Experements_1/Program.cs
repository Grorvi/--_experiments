﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine());
      
 int max = a;

if (a > max) max = a;
if (b > max) max = b;
      
int min = a;
      
if (a < min) min = a;
if (b < min) min = b;
      
Console.Write("min = ");
Console.WriteLine(min);

Console.Write("max = ");
Console.WriteLine(max);