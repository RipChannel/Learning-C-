﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num)
{
    if (i % 2 == 0)
    Console.Write($"{i} ");
    i = i + 1;
}
