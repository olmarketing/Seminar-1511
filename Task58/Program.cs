// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
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

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix2;
}

void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (j < matrix2.GetLength(1) - 1)
                Console.Write($"{matrix2[i, j],4}, ");
            else Console.Write($"{matrix2[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

bool CheckSizeMatrix(int[,] matrix, int[,] matrix2)
{
    return (matrix.GetLength(1) == matrix2.GetLength(0));
}

int[,] MultiplyMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] multiplyMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    if (CheckSizeMatrix(matrix, matrix2) == true)
    {
        for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyMatrix.GetLength(1); j++)
            {
                multiplyMatrix[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    multiplyMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }

    }
    return multiplyMatrix;
}


int[,] matrix = CreateMatrixRndInt1(3, 3, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt2(3, 2, 1, 9);
PrintMatrix2(matrix2);
CheckSizeMatrix(matrix, matrix2);
Console.WriteLine();
Console.WriteLine(CheckSizeMatrix(matrix, matrix2) ? "Перемноженная матрица"
: "Количество строк и столбцов разное, умножение не возможно");
Console.WriteLine();
int[,] multiplyMatrix = MultiplyMatrix(matrix, matrix2);
PrintMatrix(multiplyMatrix);

