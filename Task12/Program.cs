// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());

// bool Multiply(int numb1, int numb2)
// {
//     if (numb1 % numb2 == 0) return true;
//     return false;
// }

// bool result = Multiply(a, b);
// Console.WriteLine(result ? "Кратно" : $"Некратно, остаток = {a % b}");

int Multiply(int numb1, int numb2)
{
    return numb1 % numb2;
}

int result = Multiply(a, b);
Console.WriteLine(result == 0 ? "Кратно" : $"Некратно, остаток = {result}");
