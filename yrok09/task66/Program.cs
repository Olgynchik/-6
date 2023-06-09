// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void summNumbers (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine(sum); 
        return;
    }
    sum = sum + (m++);
    summNumbers(m, n, sum);
}
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
summNumbers(m, n, 0);