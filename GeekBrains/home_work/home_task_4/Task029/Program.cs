﻿Console.Clear();
int[] array = new int[8];

void FilledArray(int[] collection)
{
	for (int i = 1; i < collection.Length; i++)
	{
		collection[i] = new Random().Next(0, 100);
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}


FilledArray(array);
