// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
int n = 12;
int[] array = new int[n];

void FillArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + "   ");
}
}

int SumMinusDigits() 
{
int summinus = 0;  
for (int j = 0; j < n; j++)
{
    if (array[j] < 0)
    {
    summinus = summinus + array[j];
    }
}
return summinus;
}

int SumPlusDigits() 
{
int sumplus = 0;   
for (int k = 0; k < n; k++)
{
    if (array[k] >= 0)
    {
    sumplus = sumplus + array[k];
    }
}
return sumplus;
}


FillArray(array);
Console.WriteLine(" ");
Console.WriteLine($"Сумма отрицательных чисел массива равна:  {SumMinusDigits()}");
Console.WriteLine($"Сумма положительных чисел массива равна:  {SumPlusDigits()}");