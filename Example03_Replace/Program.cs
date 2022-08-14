// Написать программу замену элементов массива на противоположные
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + "   ");
}
}

FillArray(array);
Console.WriteLine();

void Replace()
{
for (int j = 0; j < n; j++)
{
    array[j] = -1 * array[j];
    Console.Write(array[j] + "   ");
}
}

Replace();