﻿// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Type the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

 int[,] matrix = new int[row, col];

 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
        Console.Write(matrix[i,j]);
    }
Console.WriteLine();
 }