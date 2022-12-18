// Напишите программу, которая будет принимать на вход числои и
// возвращать сумму его цифр

// 435 - 12
// 45 - 9

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

SumDigits(number);
int SumDigits(int numb)
{

    return numb != 0 ? numb % 10 + SumDigits(numb / 10) : 0;
   
}
Console.WriteLine(SumDigits(number));

