﻿// Напишите программу,которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти: ");
string number = Console.ReadLine();


string Coord(string num)
{
    if (num == "1") return "x > 0 y > 0";
    if (num == "2") return "x < 0 y > 0";
    if (num == "3") return "x < 0 y < 0";
    if (num == "4") return "x > 0 y > 0";
    return "Некорректное значение";

}

string coord = Coord(number);
Console.WriteLine(coord);
