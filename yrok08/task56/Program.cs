﻿// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();

    }
}

void RowSum(int[,] matrix)
{
    int sum = 0;
    int max = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            max = max + matrix[i, j];
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < max)
        {
            max = sum;
            count = i + 1;
        }
        sum = 0;
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов: {count} строка");

}

int[,] matrix = FillMatrix(5, 4, 0, 10);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
RowSum(matrix);
