﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите число  = ");
int N = int.Parse(Console.ReadLine()!);

int a1 = N/10;
int a11 = N/100;
int a3 = N%10;
int a2 = a1%10;

Console.WriteLine("Второе число " + a2);