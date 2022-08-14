// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int n = 8;
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + "   ");
}
}

FillArray(array);
