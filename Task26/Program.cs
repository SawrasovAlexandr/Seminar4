﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetCountNums(int number)
{
    int count = 0;
    while(number>0)
    {
        number/=10;
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {GetCountNums(16)}");
