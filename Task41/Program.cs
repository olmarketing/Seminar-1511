// Пользователь вводит с клавиатуры m чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine($"Сколько чисел хотите ввести: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array1 = EnterNumbers(m);

PrintArray(array1);
Console.WriteLine($"Колличество чисел больше нуля = {PositiveNumbers(array1)}");

int[] EnterNumbers(int m1)
{
    int[] array2 = new int[m1];
    for (int i = 0; i < m1; i++)
    {
        Console.WriteLine($"Введите число");
        array2[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array2;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

