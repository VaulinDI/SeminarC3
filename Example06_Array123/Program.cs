// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int n = 123;
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i] + " ");
}
}

FillArray(array);
Console.WriteLine();

int count = 0;
void CountElements()
{
for (int j = 0; j < n; j++)
{
    if (array[j] >= 10 && array[j] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов из отрезка [10,99] равно {count}");
}

CountElements();