/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Получение числа строк и столбцов матрицы
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

// Создание матрицы, заполненной случайными числами
int[,] InitMatrix(int rowsCount, int columnsCount)
{
    int[,] result = new int[rowsCount, columnsCount];
    Random random = new Random();
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        for (int j = 0; j < result.GetLength(1); ++j)
        {
            result[i, j] = random.Next(0, 10);
        }
    }
    return result;
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

// Сортировка матрицы по убыванию элементов в строках
void SortingMatrixDescendingOrderElementsInRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; ++j)
        {
            int maxPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); ++k)
            {
                if(matrix[i, k] > matrix[i, maxPosition])
                    maxPosition = k;
            }
            int temporary = matrix[i, maxPosition];
            matrix[i, maxPosition] = matrix[i, j];
            matrix[i, j] = temporary;
        }
    }
}


int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matr = InitMatrix(rows, columns);
PrintMatrix(matr);
Console.WriteLine();
SortingMatrixDescendingOrderElementsInRows(matr);
PrintMatrix(matr);