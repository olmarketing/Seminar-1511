// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник
// со сторонами такой длины.
// Каждая сторона треугольника меньше
// суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a1, int b1, int c1)
{
    return a1 < b1+c1 && b1< a1+c1 && c1< a1+b1;
}

Console.WriteLine(Triangle(a,b,c) ? 
"Такой треугольник существует" 
: "Такого треугольника не существует");


