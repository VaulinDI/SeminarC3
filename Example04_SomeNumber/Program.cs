// Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 101);
    Console.Write(array[i] + "   ");
}
}

Console.WriteLine("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());

void SomeNumber()
{
int count = 0;
for (int j = 0; j < n; j++)
{
    if (y == array[j])
    {
        count++;
    }
}
if (count > 0)
{
    Console.WriteLine($"Число {y} присутствует в заданном массиве");
}
else
{
    Console.WriteLine($"Числа {y} нет в заданном массиве");
}
}

FillArray(array);
Console.WriteLine();
SomeNumber();