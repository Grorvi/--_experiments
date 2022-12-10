﻿// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Ведите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Ведите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Ведите z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Ведите x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Ведите y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Ведите z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
Console.WriteLine(result);