﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Пожалуйста введите число,");
Console.WriteLine("чтобы узнать является ли оно чётным.");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
Console.WriteLine("Число " + num + " чётное");
}
else
{
Console.WriteLine("Число " + num + " нечётное");
}