// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите строку: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int b = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int NumElementsMatrix(int[,] matrix, int a1, int b1)
{
     int num=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
             for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (a1< matrix.GetLength(0) && b1 < matrix.GetLength(1))  num = matrix[a1-1,b1-1];
        }

    }
    return num;
}


bool CheckIndexElements(int[,] matrix, int a1, int b1)
{
if (a1 < matrix.GetLength(0) && b1 < matrix.GetLength(1)) return true;
else return false;
}

int[,] array = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array);
int number = NumElementsMatrix(array,a,b);
Console.WriteLine(CheckIndexElements(array,a,b) ? ($"Это элемент {number}") : ($"Такого элемента нет") );


