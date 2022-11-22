// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212->нет
// 12821->да
// 23432->да

Console.WriteLine("Введите пятизначное число");
int fiveNumber = Convert.ToInt32(Console.ReadLine());
if (fiveNumber < 10000 | fiveNumber > 99999)
Console.WriteLine("Это не пятизначное число");
else
{

int NewNumber(int number5)
{

    int num5 = number5 % 10; 
    int div = number5 / 10; 
    int num4 = div % 10; 
    div = div / 10; 
    int num3 = div % 10; 
    div = div / 10; 
    int num2 = div % 10; 
    div = div / 10; 

    int result = num5 * 10000 + num4 * 1000 + num3 * 100 + num2 * 10 + div;

    return result;
}

int res = NewNumber(fiveNumber);
Console.WriteLine(res == fiveNumber ? "Да" : "Нет");
}