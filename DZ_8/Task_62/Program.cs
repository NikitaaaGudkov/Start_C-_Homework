/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Получение размерности квадратной матрицы
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число не положительное!");
        }
    }
    return result;
}

// Спиральное заполнение матрицы 4 на 4
int[,] InitMatrix(int dimension)
{
    if (dimension == 1)
    {
        return new int[,] { { 1 } };
    }
    int[,] result = new int[dimension, dimension];
    bool[,] checkMatrix = new bool[dimension, dimension];
    int i = 0;
    int j = -1;
    int value = 1;
    while (value <= dimension * dimension)
    {
        ++j;
        Recursion(result, checkMatrix, ref i, ref j, ref value);
    }
    return result;
}

// Рекурсивное заполнение матрицы
void Recursion(int[,] matrix, bool[,] checkMatrix, ref int i, ref int j, ref int value)
{
    matrix[i, j] = value;
    ++value;
    checkMatrix[i, j] = true;
    if (j < (checkMatrix.GetLength(1) - 1) && !checkMatrix[i, j + 1])
    {
        ++j;
        Recursion(matrix, checkMatrix, ref i, ref j, ref value);
    }
    if (i < (checkMatrix.GetLength(0) - 1) && !checkMatrix[i + 1, j])
    {
        ++i;
        Recursion(matrix, checkMatrix, ref i, ref j, ref value);
    }
    if (j > 0 && !checkMatrix[i, j - 1])
    {
        --j;
        Recursion(matrix, checkMatrix, ref i, ref j, ref value);
    }
    while(!checkMatrix[i - 1, j])
    {
        matrix[i - 1, j] = value;
        ++value;
        checkMatrix[i - 1, j] = true;
        --i;
    }
}

// Вывод матрицы на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int dimension = GetNumber("Введите размерность квадратной матрицы: ");
int[,] matrix = InitMatrix(dimension);
Console.WriteLine("Спирально заполненная матрица: ");
PrintMatrix(matrix);
