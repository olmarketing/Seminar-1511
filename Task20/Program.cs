// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

Console.Write("Введите точку XA: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите точку YA: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите точку XB: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите точку YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int xb, int yb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double result = Math.Sqrt(xc + yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.Write(resRound);