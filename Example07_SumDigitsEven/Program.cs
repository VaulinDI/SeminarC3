// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + "   ");
}
}

FillArray(array);
Console.WriteLine();

int sum = 0;
void SumNoneven()
{
for (int j = 0; j < n; j++)
{
    if (j % 2 != 0)
    {
        sum = sum + array[j];
    }
}
Console.WriteLine($"Сумма чисел массива, стоящих на нечетной позиции равна: {sum}");
}

SumNoneven();