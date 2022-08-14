﻿// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

void FillArray(double[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().NextDouble() * 40 - 20;
    Console.Write(array[i] + "   ");
}
}

FillArray(array);
Console.WriteLine();

double max = Double.MinValue;
double MaxNumber()
{
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
return max;
}

double min = Double.MaxValue;
double MinNumber()
{
for (int k = 0; k < n; k++)
{
    if (array[k] < min)
    {
        min = array[k];        
    }
}
return min;
}

Console.WriteLine(MaxNumber());
Console.WriteLine(MinNumber());
Console.WriteLine(MaxNumber() - MinNumber());