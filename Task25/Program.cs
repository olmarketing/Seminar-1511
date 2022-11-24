// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0)
{
    Console.WriteLine($"Число {b} не натуральное");
}
else
{
    int degree = Degree(a, b);
    Console.WriteLine($"{a} в степени {b} равно {degree}");
}

    int Degree(int a1, int b1)
    {
        int res = a1;
        for (int i = 1; i < b1; i++)
        {
            res = res * a1;
        }
        return res;
    }
    