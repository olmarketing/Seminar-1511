// Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 20 мин 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1)  
        Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

bool FindElement(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
            }
return false;
}
bool findElement = FindElement(array, number);
Console.WriteLine(FindElement(array, number) ? "Да" : "Нет");