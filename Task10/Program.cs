// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 | number > 999)
Console.WriteLine("Это не трехзначное число");
else{
int view = ViewSecondNumber(number);
Console.WriteLine(view);
}

int ViewSecondNumber(int num)
{
    int firstSecondNum = num / 10;
    int secondNum = firstSecondNum % 10;
    return secondNum;
}

