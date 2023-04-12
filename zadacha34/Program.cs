// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




void FillArray(int[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    
}

int Chetnoe(int[] array)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i]%2 == 0)
        {
            count ++;
        }
    }
    return count;
}

Console.Clear();
int[] arr = new int [10];
FillArray(arr,100,999);
System.Console.WriteLine(string.Join($",", arr));
System.Console.WriteLine($"Колличество четных чисел в масиве = {Chetnoe(arr)}");