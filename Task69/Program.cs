// Напишите программу,которая принимает на вход числа А и В 
// и возводит число А в целую степень в

// 3,5 - 243
// 2,3 - 8

Console.WriteLine("Введите натуральное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int DegreeNumber(int number, int degree)
{
    if (degree == 0) return 1;
    return number*(DegreeNumber(number,degree-1));
  
}
Console.WriteLine(DegreeNumber(number1,number2));