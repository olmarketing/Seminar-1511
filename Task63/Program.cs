// Задайте значение N
// Напишите программу,которая выведет все натуральные числа в промежутке от 1 до N
// N=5 1,2,3,4,5


Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumber(n);
void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num} ");
}