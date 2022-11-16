// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int number)
{

    if (number % 7 == 0 && number % 23 == 0) return true;
    return false;
}

bool result = Multiplicity(num);
Console.WriteLine(result ? "Да" : "Нет");