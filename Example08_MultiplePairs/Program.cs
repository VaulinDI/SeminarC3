// Найти произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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

int[] newarray = new int[n];
newarray = array.Reverse().ToArray();

for (int j = 0; j < n; j++)
{
   Console.Write(newarray[j] + "   ");
}
Console.WriteLine();

int pow = 0;
void MultiplePairs()
{
for (int k = 0; k < n / 2; k++)
{
    pow = array[k] * newarray[k];
    Console.Write(pow + "   ");
}
}

MultiplePairs();