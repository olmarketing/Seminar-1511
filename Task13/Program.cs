// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;

int ThirdDigit(int num)
{

    while (num > 999)
    {
        {
            num = num / 10;
        }
    }
    num = num % 10;
    return num;

}

Console.WriteLine(number > 99 ? $"Третья цифра {ThirdDigit(number)}" : "Третьей цифры нет");

