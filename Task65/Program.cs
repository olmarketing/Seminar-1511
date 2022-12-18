// Задайте значение N и M
// Напишите программу,которая выведет все натуральные числа в промежутке от M до N
// N=5 M=1 1,2,3,4,5

Console.WriteLine("Введите натуральное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumber(number1, number2);
void NaturalNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        NaturalNumber(num1, num2 + 1);
        Console.Write($"{num2} ");

    }
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumber(num1 + 1, num2);

    }
    if (num1 == num2)
    {
        Console.Write($"{num1} ");
    }
}