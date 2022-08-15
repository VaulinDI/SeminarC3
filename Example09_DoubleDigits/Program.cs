// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
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

double MaxNumber()
{
double max = Double.MinValue;
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
return max;
}

double MinNumber()
{
double min = Double.MaxValue;    
for (int k = 0; k < n; k++)
{
    if (array[k] < min)
    {
        min = array[k];        
    }
}
return min;
}

FillArray(array);
Console.WriteLine();
Console.WriteLine(MaxNumber());
Console.WriteLine(MinNumber());
Console.WriteLine(MaxNumber() - MinNumber());