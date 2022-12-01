// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);

    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double[] array = CreateArrayRndDouble(6, 0, 10);
PrintArray(array);

double MaxNumberAtArray(double[] arr)
{
    double maxnumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxnumber) maxnumber = arr[i];
    }
    return maxnumber;
}

double MinNumberAtArray(double[] arr)
{
    double minnumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minnumber) minnumber = arr[i];
    }
    return minnumber;
}

double maxNumber = MaxNumberAtArray(array);
double minNumber = MinNumberAtArray(array);

double Difference(double maxNumber, double minNumber)
{
    double dif = maxNumber - minNumber;
    return dif;
}
double difference = Difference(maxNumber, minNumber);
Console.WriteLine($"Разница между максимальным и минимальным равно {Math.Round(difference, 2)}");