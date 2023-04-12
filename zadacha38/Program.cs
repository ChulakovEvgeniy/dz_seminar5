// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
void FillArray(double[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 2);
    }

}
(double max, double min) MaxAndMin (double[] array)
{
    int length = array.Length;
    double max = array[0]; 
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
} 

double[] moyMasiv = new double[10];
FillArray(moyMasiv,0,10);
(double max, double min) = MaxAndMin(moyMasiv);
System.Console.WriteLine(string.Join("; ", moyMasiv));
System.Console.WriteLine($"Разница между максимльным {max} и минимальным {min} = {Math.Round(max - min, 2)} ");

