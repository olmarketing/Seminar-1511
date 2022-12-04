// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// 45->101101
// 3-> 11
// 2->10

string Binary(int numb)
{
    string bin = string.Empty;
    while (numb> 0) 
    {
        bin = numb % 2 + bin; 
        numb /= 2; 
    }
    return bin; 

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Binary(number));