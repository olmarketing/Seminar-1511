// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumElements(int m, int n)
{
    if (m > n)
    {
        return m + SumElements(m-1,n);
    }
    else
    {
        if (m < n)
        {
            return m + SumElements(m+1, n);
        }
    }
    return m;

}

Console.WriteLine(SumElements(number1, number2));




