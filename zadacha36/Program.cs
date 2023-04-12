// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    
}

int SumNeChetnihIndex(int[] array)
{
    int length = array.Length;
    int sum = 0;
    for (int i = 1; i < length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}

Console.Clear();
int[] moyMasiv = new int [5];
FillArray(moyMasiv,-100, 100);
System.Console.WriteLine(string.Join(",", moyMasiv));
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях массива = {SumNeChetnihIndex(moyMasiv)}");