﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// Console.WriteLine("Первое число - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Второе число - ");
// int b = Convert.ToInt32(Console.ReadLine());

// void Multiply(int numb1, int numb2)
// {
//     if (numb1 % numb2 == 0 )
//     {
//         Console.WriteLine($"Число {numb1} кратное числу {numb2}");
//     }
//     else
//     Console.WriteLine($"Остаток от деления {numb1} на число {numb2} = {numb1 % numb2}");
   
// }

// Multiply(a,b);


Console.WriteLine("Первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число - ");
int b = Convert.ToInt32(Console.ReadLine());

bool Multiply(int numb1, int numb2)
{
    if (numb1 % numb2 == 0 ) return true;
    return false;
}

bool result  = Multiply(a,b);
Console.WriteLine(result ? "Кратно" : $"Некратно, остаток = {a % b}");
