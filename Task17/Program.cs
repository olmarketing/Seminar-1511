// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причем X не равно 0 и Y не равно 0
// и выдает номер четверти в плоскости, в которой находится эта точка

Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xx, int yy)
{
    if (xx > 0 && yy > 0) return 1;
    if (xx < 0 && yy > 0) return 2;
    if (xx < 0 && yy < 0) return 3;
    if (xx > 0 && yy > 0) return 4;
    return 0;

}

int quarter = Quarter(x, y);
string result = quarter > 0
? $"Указанные координаты соответствуют четверти -> {quarter}"
: "Введены некооректные координаты";

Console.WriteLine(result);