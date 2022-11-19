// Напишите программу, которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N.

int number = -1;
while (number < 1)
{
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
if (number<1) Console.Writeline("Введите положительное значение");
}

void Square(int num)
{

    // int i = 1;
    // while (i<=num);
for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} -> {i*i}");
    //i++;
}
}

Square(number);