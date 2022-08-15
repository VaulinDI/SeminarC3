// Задать массив, заполнить случайными положительными трёхзначными числами
// Показать количество нечетных\четных чисел
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + "   ");
}
}

void EvenDigits()
{
int counteven = 0;
int countnoneven = 0;
for (int j = 0; j < n; j++)
{
    if (array[j] % 2 == 0)
    {
        counteven++;
    }
    if (array[j] % 2 != 0)
    {
        countnoneven++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве равно {counteven}");
Console.Write($"Количество нечетных чисел в массиве равно {countnoneven}");
}

FillArray(array);
Console.WriteLine();
EvenDigits();