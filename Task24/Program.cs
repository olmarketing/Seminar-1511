﻿// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{

    int sum = default;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

if (number > 0)
{
    int sumDigits = SumDigits(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumDigits}");

}

else Console.WriteLine("Требуется внести натуральное число");

