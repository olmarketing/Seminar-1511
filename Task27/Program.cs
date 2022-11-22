// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;

int SumDigit(int num)
{
    int sum = 0;
    for (int i = 0; i <= sum; i++)
    {
        int num1 = num % 10; //2
        num = num / 10; //45
        sum = sum + num1;
    }
    return sum;
}

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);