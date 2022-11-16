﻿/*
Задайте значение N. Напишите программу, 
которая выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"
*/

Console.Clear();
Console.WriteLine("Enter a value: ");
int number = int.Parse(Console.ReadLine());
int newNumber = 0;
ReturnNumber(number);

void ReturnNumber(int number)
{
	Console.Write(newNumber + " ");
	if (newNumber >= number)
	{
		return;
	}
	newNumber++;
	ReturnNumber(number);
}