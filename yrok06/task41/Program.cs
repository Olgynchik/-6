﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите числа ");
int [] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }

}
System.Console.WriteLine($"Количество положительных  чисел = {count}");



// int number(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int NewMass = number("Введите количество чисел: ");
// int PositiveNums()
// {
//     int Positive = 0;
//     for (int i = 0; i < NewMass; i++)
//     {
//         Console.WriteLine($"Введите число {i + 1}: ");
//         int num = Convert.ToInt32(Console.ReadLine());

//         if (num > 0)
//             Positive++;
//     }
//     return Positive;
// }
// Console.WriteLine($"Положительных чисел: {PositiveNums()}");